using AromaShop.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AromaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Ultility.Util.Role_Admin + "," + Ultility.Util.Role_Employee)]

    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
