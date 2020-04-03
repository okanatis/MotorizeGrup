using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class Customers
    {
        public Customers()
        {
            AirShipTickets = new HashSet<AirShipTickets>();
            CarsHasRent = new HashSet<CarsHasRent>();
            RestaurantCoupons = new HashSet<RestaurantCoupons>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhone { get; set; }

        public virtual ICollection<AirShipTickets> AirShipTickets { get; set; }
        public virtual ICollection<CarsHasRent> CarsHasRent { get; set; }
        public virtual ICollection<RestaurantCoupons> RestaurantCoupons { get; set; }
    }
}
