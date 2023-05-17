using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace AromaShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            ViewBag.location = "shop";

            // get Categories for sidebar
            var categories = _unitOfWork.Category.GetAll();
            foreach (var category in categories)
            {
                category.Count = _unitOfWork.Product.GetAll(u => u.BrandId == category.Id).Count();
            }

            // get Brands for sidebar
            var brands = _unitOfWork.Brand.GetAll();
            foreach (var brand in brands)
            {
                brand.Count =  _unitOfWork.Product.GetAll(u => u.BrandId == brand.Id).Count();
            }

            // get Colors for sidebar
            var colors = _unitOfWork.Color.GetAll();
            foreach (var color in colors)
            {
                color.Count = _unitOfWork.Product.GetAll(u => u.BrandId == color.Id).Count();
            }


            CategoryViewModel categoryVM = new() 
            { 
                Categories = categories,
                Brands = brands,
                Colors = colors,
            };

            return View(categoryVM);
        }
    }
}
