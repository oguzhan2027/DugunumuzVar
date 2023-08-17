using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
