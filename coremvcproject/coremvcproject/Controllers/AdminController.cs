using Microsoft.AspNetCore.Mvc;

namespace coremvcproject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
