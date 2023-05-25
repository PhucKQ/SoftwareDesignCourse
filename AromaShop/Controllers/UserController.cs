using AromaShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AromaShop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // check duplicate username
                

                // check duplicate email

            }
            return View();
        }
    }
}
