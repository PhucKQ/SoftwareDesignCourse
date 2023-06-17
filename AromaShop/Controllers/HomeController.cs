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

        public IActionResult MyOrder(string? status = "all", int pageNumber = 1)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            List<OrderVM> orderList = new();
            IEnumerable<OrderHeader> orderHeaders = _unitOfWork.OrderHeader.GetAll(u => u.UserId == userId);
            foreach (var header in orderHeaders)
            {
                OrderVM order = new()
                {
                    OrderHeader = header,
                    OrderDetails = _unitOfWork.OrderDetail.GetAll (u => u.OrderHeaderId == header.Id)
                };
                foreach (var detail in order.OrderDetails)
                {
                    detail.Product = _unitOfWork.Product.Get(u => u.Id == detail.ProductId);
                }
                orderList.Add(order);
            }

            switch (status)
            {
                case "pending":
                    orderList = orderList.Where(u => u.OrderHeader.OrderStatus == Util.StatusPending).ToList();
                    break;
                case "approved":
                    orderList = orderList.Where(u => u.OrderHeader.OrderStatus == Util.StatusApproved).ToList();
                    break;
                case "inprocess":
                    orderList = orderList.Where(u => u.OrderHeader.OrderStatus == Util.StatusInProcess).ToList();
                    break;
                case "shipped":
                    orderList = orderList.Where(u => u.OrderHeader.OrderStatus == Util.StatusShipped).ToList();
                    break;
                case "cancelled":
                    orderList = orderList.Where(u => u.OrderHeader.OrderStatus == Util.StatusCancelled).ToList();
                    break;
                case "refunded":
                    orderList = orderList.Where(u => u.OrderHeader.OrderStatus == Util.StatusRefunded).ToList();
                    break;
            }

            PaginatedList<OrderVM> paginatedOrders = PaginatedList<OrderVM>.Create(orderList, pageNumber, 5);

            return View(paginatedOrders);
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