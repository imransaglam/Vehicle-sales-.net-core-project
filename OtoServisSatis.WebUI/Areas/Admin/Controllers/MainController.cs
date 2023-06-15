using Microsoft.AspNetCore.Mvc;

namespace OtoServisSatis.WebUI.Controllers
{
    public class MainController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
