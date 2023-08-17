using Microsoft.AspNetCore.Mvc;
using DugunumuzVar.BusinessLayer.Abstract;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _BookingPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //private readonly IBookingService _bookingService;

        //public _BookingPartial(IBookingService bookingService)
        //{
        //    _bookingService = bookingService;
        //}
        //public IViewComponentResult Invoke()
        //{
        //    var values = _bookingService.TGetList();
        //    return View(values);
        //}
    }
}
