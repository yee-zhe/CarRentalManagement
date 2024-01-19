using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int id { get; set; }
        public DateTime Datecreated { get; set; }
        public DateTime Dateupdated { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get;set; }
    }
}
