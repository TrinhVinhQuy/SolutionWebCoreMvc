using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin-home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
