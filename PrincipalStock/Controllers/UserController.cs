using Microsoft.AspNetCore.Mvc;

namespace PrincipalStock.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
