using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class Restauranties
    {
        public Restauranties()
        {
            RestaurantCoupons = new HashSet<RestaurantCoupons>();
        }

        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public int? DisctIdNumb { get; set; }

        public virtual District DisctIdNumbNavigation { get; set; }
        public virtual ICollection<RestaurantCoupons> RestaurantCoupons { get; set; }
    }
}
