using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (string.IsNullOrEmpty(loginViewModel.Id)) 
            {
                return View("Index");

            }
            else if (string.IsNullOrEmpty(loginViewModel.PassWord))
            {
                return View("Index");

            }
            return RedirectToAction("Index","Home");
        }
    }
}
