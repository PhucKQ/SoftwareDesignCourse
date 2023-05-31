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

        public IActionResult Upsert(string? userId)
        {
            UserCreateOrUpdateVM userUpsertVM;

            if (string.IsNullOrEmpty(userId))
            {
                userUpsertVM = new()
                {
                    User = new User(), // cant be achieved Create function cuz new User() will create a new GuidId for User instance
                    Roles = GetRolesList()
                };
            }
            else
            {
                var userFromDb = _userManager.FindByIdAsync(userId).GetAwaiter().GetResult();

                if (userFromDb == null)
                {
                    return NotFound();
                }

                userUpsertVM = new()
                {
                    User = (User)userFromDb,
                    Roles = GetRolesList()
                };

                userUpsertVM.User.Role = _userManager.GetRolesAsync(userFromDb).GetAwaiter().GetResult().FirstOrDefault();
            }

            return View(userUpsertVM);
        }

        
        // error with edit User
        //
        //
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(UserCreateOrUpdateVM model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                model.User.AvatarPath = Util.UploadImage(model.User.AvatarPath, file, _webHostEnvironment.WebRootPath, "user");
                if (string.IsNullOrEmpty(model.User.Id))
                {
                    model.User.Id = Guid.NewGuid().ToString();
                    _userManager.CreateAsync(model.User);

                    if (!string.IsNullOrEmpty(model.User.Role))
                    {
                        _userManager.AddToRoleAsync(model.User, model.User.Role);
                    }
                    else
                    {
                        _userManager.AddToRoleAsync(model.User, Util.Role_Customer);
                    }
                }
                else
                {
                    //var userFromDb = _unitOfWork.User.Get(u => u.Id == model.User.Id);
                    var userFromDb = _userManager.FindByIdAsync(model.User.Id).GetAwaiter().GetResult();
                    if (userFromDb == null)
                    {
                        return NotFound();
                    }

                    var oldRole = _userManager.GetRolesAsync(userFromDb).GetAwaiter().GetResult().FirstOrDefault();
                    // handle when change Role
                    if (oldRole != null && oldRole != model.User.Role)
                    {
                        _userManager.RemoveFromRoleAsync(userFromDb, oldRole).GetAwaiter().GetResult();
                        _userManager.AddToRoleAsync(userFromDb, model.User.Role).GetAwaiter().GetResult();
                        _userManager.UpdateAsync(userFromDb).GetAwaiter().GetResult();
                    }
                    
                    userFromDb = model.User;
                    
                    _userManager.UpdateAsync(userFromDb).GetAwaiter().GetResult();

                    //_unitOfWork.User.Update(userFromDb);
                    //_unitOfWork.Save();
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
