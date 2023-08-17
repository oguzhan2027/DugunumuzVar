using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
