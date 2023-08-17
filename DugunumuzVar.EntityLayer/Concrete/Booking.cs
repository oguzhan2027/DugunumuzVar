using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.EntityLayer.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }

        public string CustomerName { get; set; }
        public string Subject { get; set; }

        public string OrganizationType { get; set; }

        public int People { get; set; }

        public string Mail { get; set; }

        public DateTime BookingDate { get; set; }

        public string BookingStatus { get; set; }
    }
}
