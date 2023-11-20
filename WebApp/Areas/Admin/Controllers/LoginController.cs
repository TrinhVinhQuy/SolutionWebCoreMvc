using DataAccess.Login;
using Microsoft.AspNetCore.Mvc;
using Repositories.Login;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        private ILoginRepository _loginRepository= new LoginRepository();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var reuslt = await _loginRepository.CheckLogin(model);
                if (reuslt == 1)
                {
                    //TempData["Info"] = "Admin";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Fail"] = "Tên đăng nhập hoặc mật khẩu không đúng!";
                }
            }
            else
            {
                ModelState.AddModelError("Error",
                                 "Please input field full!");
            }
            return View(model);
        }
    }
}
