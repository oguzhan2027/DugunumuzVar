using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
