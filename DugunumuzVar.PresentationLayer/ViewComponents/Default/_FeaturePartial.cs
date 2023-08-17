using Microsoft.AspNetCore.Mvc;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "En Özel Gününüzde";
            ViewBag.title2 = "Sizlerin yanınızdayız";
            return View();
        }
    }
}
