using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _ServicesPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
