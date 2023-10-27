using Microsoft.AspNetCore.Mvc;

namespace HortiDot.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
