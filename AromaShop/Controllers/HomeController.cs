using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services;
using AromaShop.Services.IRepository;
using AromaShop.Ultility;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace AromaShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            ViewBag.location = "home";

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                HttpContext.Session.SetInt32(Util.SessionCart,
                    _unitOfWork.ShoppingCart.GetAll(u => u.UserId == claim.Value).Count());
            }

            // get trending products
            IEnumerable<Product> trendingProducts = _unitOfWork.Product.GetAll(includeProperties: "Category")
                .OrderByDescending(t => t.OverallReview).Take(8).ToList();

            return View(trendingProducts);
        }

        public IActionResult Contact()
        {
            ViewBag.location = "contact";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}