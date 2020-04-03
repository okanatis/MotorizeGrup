using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class RestaurantCoupons
    {
        public int CouponId { get; set; }
        public string CouponDescription { get; set; }
        public int? RestId { get; set; }
        public int? CustomerIdNumb { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Customers CustomerIdNumbNavigation { get; set; }
        public virtual Restauranties Rest { get; set; }
    }
}
