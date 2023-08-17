using Microsoft.AspNetCore.Mvc;
using DugunumuzVar.BusinessLayer.Abstract;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _ProductPartial: ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetList();
           return View(values);
        }
    }
}
