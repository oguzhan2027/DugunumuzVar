using DugunumuzVar.BusinessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.EntityFramework;
using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TDelete(Booking t)
        {
           _bookingDal.Delete(t);
        }

        public List<Booking> TGetBookingBySubjectWithTesekkur()
        {
            return _bookingDal.GetBookingBySubjectWithTesekkur();
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
           return _bookingDal.GetList();
        }

        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }

        public void Tİnsert(Booking t)
        {
            _bookingDal.İnsert(t);
        }
    }
}
