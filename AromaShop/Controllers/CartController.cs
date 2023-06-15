using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using AromaShop.Ultility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using System.Security.Claims;

namespace AromaShop.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

            double orderTotal = 0;
            var cartsFromDb = _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId).ToList();

            foreach (var cart in cartsFromDb)
            {
                cart.Product = _unitOfWork.Product.Get(u => u.Id == cart.ProductId);
                cart.Total = cart.Count * cart.Product.Price;
                orderTotal += cart.Total;
            }

            ShoppingCartVM shoppingCartVM = new ShoppingCartVM()
            {
                ShoppingCartList = cartsFromDb,
                OrderHeader = new()
                {
                    OrderTotal = orderTotal,
                    UserId = userId
                }
            };

            return View(shoppingCartVM);
        }

        [HttpPost]
        public IActionResult UpdateCart(ShoppingCartVM shoppingCartVM)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

            shoppingCartVM.OrderHeader = new() { OrderTotal = 0 };
            foreach (var cart in shoppingCartVM.ShoppingCartList)
            {
                var cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cart.Id);
                cartFromDb.Product = _unitOfWork.Product.Get(u => u.Id == cart.Product.Id);

                if (cart.Count <= 0)
                {
                    _unitOfWork.ShoppingCart.Remove(cartFromDb);
                }
                else
                {
                    if (cart.Count != cartFromDb.Count)
                    {
                        cartFromDb.Count = cart.Count;
                        _unitOfWork.ShoppingCart.Update(cartFromDb);
                    }
                    cartFromDb.Total = cart.Count * cartFromDb.Product.Price;
                    shoppingCartVM.OrderHeader.OrderTotal += cartFromDb.Total;
                }
            }
            _unitOfWork.Save();
            HttpContext.Session.SetInt32(Util.SessionCart,
                _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId).Count());

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Checkout()
        {
            var claims = (ClaimsIdentity)User.Identity;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

            var cartsFromDb = _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId).ToList();
            double orderTotal = 0;
            foreach (var cart in cartsFromDb)
            {
                cart.Product = _unitOfWork.Product.Get(u => u.Id == cart.ProductId);
                cart.Total = cart.Count * cart.Product.Price;
                orderTotal += cart.Total;
            }

            ShoppingCartVM shoppingCartVM = new()
            {
                ShoppingCartList = cartsFromDb,
                OrderHeader = new OrderHeader() { User = _unitOfWork.User.Get(u => u.Id == userId), OrderTotal = orderTotal }
            };

            return View(shoppingCartVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlaceOrder(ShoppingCartVM model)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ShoppingCartList = _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId).ToList();

            // fill in OrderHeader fields to add a new record
            model.OrderHeader.OrderDate = System.DateTime.Now;
            model.OrderHeader.UserId = userId;
            //User user = _unitOfWork.User.Get(u => u.Id == userId); 
            //model.OrderHeader.User = user; // can not be assigned directly because of EFcore mechanism

            foreach (var cart in model.ShoppingCartList)
            {
                cart.Product = _unitOfWork.Product.Get(u => u.Id == cart.ProductId);
                model.OrderHeader.OrderTotal += cart.Product.Price * cart.Count;
            }

            model.OrderHeader.PaymentStatus = Util.PaymentStatusPending;
            model.OrderHeader.OrderStatus = Util.StatusPending;

            _unitOfWork.OrderHeader.Add(model.OrderHeader);
            _unitOfWork.Save();

            // create OrderDetail model info to add a new record
            foreach (var cart in model.ShoppingCartList)
            {
                OrderDetail orderDetail = new()
                {
                    ProductId = cart.ProductId,
                    OrderHeaderId = model.OrderHeader.Id,
                    Price = cart.Product.Price,
                    Quantity = cart.Count
                };
                _unitOfWork.OrderDetail.Add(orderDetail);
                _unitOfWork.Save();
            }
            return RedirectToAction(nameof(OrderConfirmation), new { id = model.OrderHeader.Id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlaceOrderWithStripe(ShoppingCartVM model)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ShoppingCartList = _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId).ToList();

            // fill in OrderHeader fields to add a new record
            model.OrderHeader.OrderDate = System.DateTime.Now;
            model.OrderHeader.UserId = userId;

            foreach (var cart in model.ShoppingCartList)
            {
                cart.Product = _unitOfWork.Product.Get(u => u.Id == cart.ProductId);
                model.OrderHeader.OrderTotal += cart.Product.Price * cart.Count;
            }

            model.OrderHeader.PaymentStatus = Util.PaymentStatusPending;
            model.OrderHeader.OrderStatus = Util.StatusPending;

            _unitOfWork.OrderHeader.Add(model.OrderHeader);
            _unitOfWork.Save();

            // create OrderDetail model info to add a new record
            foreach (var cart in model.ShoppingCartList)
            {
                OrderDetail orderDetail = new()
                {
                    ProductId = cart.ProductId,
                    OrderHeaderId = model.OrderHeader.Id,
                    Price = cart.Product.Price,
                    Quantity = cart.Count
                };
                _unitOfWork.OrderDetail.Add(orderDetail);
                _unitOfWork.Save();
            }

            //stripe
            string domain = "https://localhost:7154";
            var options = new SessionCreateOptions
            {
                SuccessUrl = domain + $"/Cart/OrderConfirmation?id={model.OrderHeader.Id}",
                CancelUrl = domain + "/Cart/Index",
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
            };

            foreach (var item in model.ShoppingCartList)
            {
                var sessionLineItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(item.Product.Price * 100),
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Product.Name,
                        }
                    },
                    Quantity = item.Count
                };
                options.LineItems.Add(sessionLineItem);
            }

            var service = new SessionService();
            Session session = service.Create(options);
            _unitOfWork.OrderHeader.UpdateStripePaymentId(model.OrderHeader.Id, session.Id, session.PaymentIntentId);
            _unitOfWork.Save();
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }

        public IActionResult OrderConfirmation(int id)
        {
            var orderHeader = _unitOfWork.OrderHeader.Get(u => u.Id == id);
            var orderDetails = _unitOfWork.OrderDetail.GetAll(u => u.OrderHeaderId == id);
            foreach (var item in orderDetails)
            {
                item.Product = _unitOfWork.Product.Get(u => u.Id == item.ProductId);
            }

            OrderConfirmationVM orderConfirmationVM = new()
            {
                OrderHeader = orderHeader,
                OrderDetails = orderDetails,
            };

            // check Stripe payment status
            var service = new SessionService();
            Session session = service.Get(orderHeader.SessionId);

            if (session.PaymentStatus.ToLower() == "paid")
            {
                _unitOfWork.OrderHeader.UpdateStripePaymentId(id, session.Id, session.PaymentIntentId);
                _unitOfWork.OrderHeader.UpdateStatus(id, Util.StatusApproved, Util.PaymentStatusApproved);
                _unitOfWork.Save();
            }
            HttpContext.Session.Clear();

            var userId = _unitOfWork.OrderHeader.Get(u => u.Id == id).UserId;
            IEnumerable<ShoppingCart> shoppingCarts = _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId);
            _unitOfWork.ShoppingCart.RemoveRange(shoppingCarts);
            _unitOfWork.Save();

            return View(orderConfirmationVM);
        }

    }
}
