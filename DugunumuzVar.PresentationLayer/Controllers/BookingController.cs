using Microsoft.AspNetCore.Mvc;
using DugunumuzVar.BusinessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.Concrete;
using DugunumuzVar.EntityLayer.Concrete;
using System;

namespace DugunumuzVar.PresentationLayer.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public IActionResult Index()
        {
            var values = _bookingService.TGetList();
            return View(values);
        }

        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return RedirectToAction("BookingList");
        }
        public IActionResult GetContactByThanks()
        {
            var value = _bookingService.TGetBookingBySubjectWithTesekkur();
            return View(value);
        }


        public IActionResult MessageDetailsBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return View(values);
        }

        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            booking.BookingDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _bookingService.Tİnsert(booking);
            return RedirectToAction("Index");
        }


    }
}

