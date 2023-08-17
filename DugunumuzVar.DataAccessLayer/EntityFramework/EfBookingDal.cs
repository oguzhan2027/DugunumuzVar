using DugunumuzVar.DataAccessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.Concrete;
using DugunumuzVar.DataAccessLayer.Repositories;
using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public List<Booking> GetBookingBySubjectWithTesekkur()
        {
            using var context = new Context();
            var values = context.Bookings.Where(x => x.Subject == "Teşekkür").ToList();
            return values;
        }
    }
}
