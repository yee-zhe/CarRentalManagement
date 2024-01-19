using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer:BaseDomainModel
    {
        public String? DrivingLicense {  get; set; }
        public String? Address { get; set;}
        public String? ContactNumber { get; set;}
        public String? EmailAddress { get; set;}
        public virtual List<Booking>? Bookings { get; set; }
    }
}
