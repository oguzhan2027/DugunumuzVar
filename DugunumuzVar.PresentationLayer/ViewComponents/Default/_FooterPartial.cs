using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
