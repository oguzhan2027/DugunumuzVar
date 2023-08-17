using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _ContactFormPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
