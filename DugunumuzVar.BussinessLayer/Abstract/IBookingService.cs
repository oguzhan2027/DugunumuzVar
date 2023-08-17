using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        List<Booking> TGetBookingBySubjectWithTesekkur();
    }
}
