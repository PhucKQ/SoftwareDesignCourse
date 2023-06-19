using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AromaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Ultility.Util.Role_Admin + "," + Ultility.Util.Role_Employee)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CategoryController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                model.ImagePath = Ultility.Util.UploadImage(model.ImagePath, file, wwwRootPath, "category");

                _unitOfWork.Category.Add(model);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            return View(objFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                model.ImagePath = Ultility.Util.UploadImage(model.ImagePath, file, wwwRootPath, "category");

                _unitOfWork.Category.Update(model);
                _unitOfWork.Save();
                TempData["success"] = "Category edited successfully";
                return RedirectToAction("Index");
            }

            return View(model);
        }


        #region API

        public IActionResult GetAll()
        {
            var categoryList = _unitOfWork.Category.GetAll();

            return Json(new { data = categoryList });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new {success = false, message = "Error while deleting"});
            }

            Ultility.Util.DeleteImage(objFromDb.ImagePath, _webHostEnvironment.WebRootPath);

            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successfully" });
        }

        #endregion
    }
}
