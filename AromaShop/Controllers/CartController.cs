using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using AromaShop.Ultility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
                cart.Total= cart.Count * cart.Product.Price;
                orderTotal += cart.Total;
            }

            ShoppingCartVM shoppingCartVM = new ShoppingCartVM()
            {
                ShoppingCartList = cartsFromDb,
                OrderHeader = new()
                {
                    OrderTotal = orderTotal,
                }
            };

            return View(shoppingCartVM);
        }

        [HttpPost]
        public IActionResult UpdateCart(ShoppingCartVM shoppingCartVM)
        {
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

        //public IActionResult PlaceOrder()
        //{
        //    return View();
        //}

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
                OrderDetail orderDetail = new OrderDetail()
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
            
            //return RedirectToAction(nameof(Checkout));
        }

        public IActionResult OrderConfirmation(int id)
        {
            var userId = _unitOfWork.OrderHeader.Get(u=>u.Id == id).UserId;
            var orderDetails = _unitOfWork.OrderDetail.GetAll(u => u.OrderHeaderId == id);
            foreach (var item in orderDetails)
            {
                item.Product = _unitOfWork.Product.Get(u => u.Id == item.Id);
            }

            OrderConfirmationVM orderConfirmationVM = new()
            {
                OrderHeader = _unitOfWork.OrderHeader.Get(u => u.Id == id),
                OrderDetails = orderDetails,
            };

            IEnumerable<ShoppingCart> shoppingCarts = _unitOfWork.ShoppingCart.GetAll(u => u.UserId == userId);
            _unitOfWork.ShoppingCart.RemoveRange(shoppingCarts);
            _unitOfWork.Save();

            return View(orderConfirmationVM);
        }

    }
}
