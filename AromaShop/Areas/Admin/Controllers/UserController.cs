using AromaShop.Models;
using AromaShop.Models.ViewModels;
using AromaShop.Services.IRepository;
using AromaShop.Ultility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AromaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(IUnitOfWork unitOfWork,
            IWebHostEnvironment webHostEnvironment,
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageRole(string userId)
        {
            RoleManagementVM roleManagementVM;
            //var userFromDb = _userManager.FindByIdAsync(userId).GetAwaiter().GetResult();
            var userFromDb = _unitOfWork.User.Get(u => u.Id == userId);
            if (userFromDb == null)
            {
                return NotFound();
            }

            roleManagementVM = new()
            {
                //User = (User)userFromDb,
                User = userFromDb,
                Roles = GetRolesList()
            };

            roleManagementVM.User.Role = _userManager.GetRolesAsync(userFromDb).GetAwaiter().GetResult().FirstOrDefault();

            return View(roleManagementVM);
        }


        // error with edit User
        //
        //
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ManageRole(RoleManagementVM model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                model.User.AvatarPath = Util.UploadImage(model.User.AvatarPath, file, _webHostEnvironment.WebRootPath, "user");
                var userFromDb = _unitOfWork.User.Get(u => u.Id == model.User.Id);
                
                if (userFromDb == null)
                {
                    return NotFound();
                }

                userFromDb.Fullname = model.User.Fullname;
                userFromDb.Email = model.User.Email;
                userFromDb.AvatarPath = model.User.AvatarPath;
                _unitOfWork.User.Update(userFromDb);
                _unitOfWork.Save();

                var oldRole = _userManager.GetRolesAsync(userFromDb).GetAwaiter().GetResult().FirstOrDefault();
                // handle when change Role
                if (oldRole != null && oldRole != model.User.Role)
                {
                    _userManager.RemoveFromRoleAsync((IdentityUser)userFromDb, oldRole).GetAwaiter().GetResult();
                    _userManager.AddToRoleAsync((IdentityUser)userFromDb, model.User.Role).GetAwaiter().GetResult();
                }
                TempData["success"] = "Edited successfully!";

                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Something went wrong!";
            model.Roles = GetRolesList();

            return View(model);
        }


        #region API

        public IActionResult GetAll()
        {
            var userList = _unitOfWork.User.GetAll();
            foreach (var user in userList)
            {
                user.Role = _userManager.GetRolesAsync(user).GetAwaiter().GetResult().FirstOrDefault();
            }

            return Json(new { data = userList });
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var objFromDb = _unitOfWork.User.Get(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            Util.DeleteImage(objFromDb.AvatarPath, _webHostEnvironment.WebRootPath);

            _unitOfWork.User.Remove(objFromDb);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successfully" });
        }

        [HttpPost]
        public IActionResult LockUnlock([FromBody] string id)
        {
            string notification = string.Empty;
            var objFromDb = _unitOfWork.User.Get(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while Locking/Unlocking" });
            }

            if (objFromDb.LockoutEnd != null && objFromDb.LockoutEnd > DateTime.Now)
            {
                // unlock account
                objFromDb.LockoutEnd = DateTime.Now;
                notification = "Unlocked account successfully";
            }
            else
            {
                // lock account
                objFromDb.LockoutEnd = DateTime.Now.AddYears(100);
                notification = "Locked account successfully";
            }
            _unitOfWork.User.Update(objFromDb);
            _unitOfWork.Save();

            return Json(new { success = true, message = notification });
        }

        #endregion

        #region Private Method
        private IEnumerable<SelectListItem> GetRolesList()
        {
            return _roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Name
            });
        }
        #endregion
    }
}
