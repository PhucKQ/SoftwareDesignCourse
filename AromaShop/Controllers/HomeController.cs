using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services;
using AromaShop.Services.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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