using AromaShop.Models;
using AromaShop.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AromaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Ultility.Util.Role_Admin + "," + Ultility.Util.Role_Employee)]

    public class ColorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ColorController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
            {
                return View(new Color());
            }
            else
            {
                var objFromDb = _unitOfWork.Color.Get(u => u.Id == id);
                return View(objFromDb);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Color model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                // handle image upload
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                model.ImagePath = Ultility.Util.UploadImage(model.ImagePath, file, wwwRootPath, "color");

                if (model.Id == 0)
                {
                    _unitOfWork.Color.Add(model);
                    TempData["success"] = "Created successfully";
                }
                else
                {
                    _unitOfWork.Color.Update(model);
                    TempData["success"] = "Updated successfully";
                }
                _unitOfWork.Save();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        

        #region API

        public IActionResult GetAll()
        {
            var colorList = _unitOfWork.Color.GetAll();

            return Json(new { data = colorList });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Color.Get(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            Ultility.Util.DeleteImage(objFromDb.ImagePath, _webHostEnvironment.WebRootPath);

            _unitOfWork.Color.Remove(objFromDb);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successfully" });
        }

        #endregion
    }
}
