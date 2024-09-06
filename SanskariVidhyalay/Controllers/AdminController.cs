using Microsoft.AspNetCore.Mvc;

namespace SanskariVidhyalay.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
