using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DugunumuzVar.BusinessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.Abstract;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }
    }
}
