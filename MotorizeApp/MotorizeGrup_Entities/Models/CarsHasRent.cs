using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class CarsHasRent
    {
        public int EventId { get; set; }
        public int? ItemsCarId { get; set; }
        public int? CustomerIdNumber { get; set; }
        public int? RentTimeDay { get; set; }

        public virtual Customers CustomerIdNumberNavigation { get; set; }
        public virtual ItemCars ItemsCar { get; set; }
    }
}
