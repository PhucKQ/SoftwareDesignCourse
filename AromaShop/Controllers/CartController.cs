using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
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
                OrderTotal = orderTotal
            };

            return View(shoppingCartVM);
        }

        [HttpPost]
        public IActionResult UpdateCart(ShoppingCartVM shoppingCartVM)
        {
            shoppingCartVM.OrderTotal = 0;
            foreach (var cart in shoppingCartVM.ShoppingCartList)
            {
                var cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cart.Id);
                cartFromDb.Product = _unitOfWork.Product.Get(u => u.Id == cart.Product.Id);

                if (cart.Count != cartFromDb.Count)
                {
                    cartFromDb.Count = cart.Count;
                    _unitOfWork.ShoppingCart.Update(cartFromDb);
                }
                cartFromDb.Total = cart.Count * cartFromDb.Product.Price;
                shoppingCartVM.OrderTotal += cartFromDb.Total;
            }
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Plus(int cartId)
        {
            var cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);
            cartFromDb.Count += 1;

            _unitOfWork.ShoppingCart.Update(cartFromDb);
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Minus(int cartId)
        {
            var cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);
            if (cartFromDb.Count <= 1)
            {
                _unitOfWork.ShoppingCart.Remove(cartFromDb);
            }
            else
            {
                cartFromDb.Count -= 1;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
            }
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }


    }
}
