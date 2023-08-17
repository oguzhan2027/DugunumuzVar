using Microsoft.AspNetCore.Mvc;
using DugunumuzVar.BusinessLayer.Abstract;
using DugunumuzVar.EntityLayer.Concrete;

namespace DugunumuzVar.PresentationLayer.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            var values=_testimonialService.TGetList();
            return View(values);
        }

        public IActionResult TestimonialDelete(int id)
        {
            var testimonial=_testimonialService.TGetByID (id);
            _testimonialService.TDelete(testimonial);
            return RedirectToAction("Index");
        }

        public IActionResult TestimonialDetails(int id)
        {
            var testimonial = _testimonialService.TGetByID(id);
            return View(testimonial);
        }

        [HttpPost]
        public IActionResult TestimonialDetails(Testimonial testimonial)
        {           
            _testimonialService.TUpdate(testimonial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            testimonial.ImageUrl = "/pizzapan-starter/pexels-cinestyle-india-1589216.jpg";
            _testimonialService.Tİnsert(testimonial);
            return RedirectToAction("Index");
        }
    }
}
