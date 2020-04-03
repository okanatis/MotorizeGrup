using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class ItemCars
    {
        public ItemCars()
        {
            CarsHasRent = new HashSet<CarsHasRent>();
        }

        public int CarItemId { get; set; }
        public int? CompanyIdNumb { get; set; }
        public int? CarId { get; set; }
        public bool? ItemIsActive { get; set; }
        public int? ItemCount { get; set; }
        public decimal? RentPrice { get; set; }
        public int? AirportIdNumb { get; set; }

        public virtual Airports AirportIdNumbNavigation { get; set; }
        public virtual Cars Car { get; set; }
        public virtual RentcarCompany CompanyIdNumbNavigation { get; set; }
        public virtual ICollection<CarsHasRent> CarsHasRent { get; set; }
    }
}
