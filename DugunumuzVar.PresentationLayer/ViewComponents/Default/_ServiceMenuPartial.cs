using Microsoft.AspNetCore.Mvc;
using DugunumuzVar.BusinessLayer.Abstract;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _ServiceMenuPartial:ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public _ServiceMenuPartial(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
           
            var values = _categoryService.TGetCategoriesWithProduct();
            return View(values);
        }
    }
}
