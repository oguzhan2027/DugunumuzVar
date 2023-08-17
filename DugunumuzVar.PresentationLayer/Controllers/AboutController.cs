using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
