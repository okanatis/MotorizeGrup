using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class Cars
    {
        public Cars()
        {
            ItemCars = new HashSet<ItemCars>();
        }

        public int CarId { get; set; }
        public string CarModel { get; set; }
        public int? CarLuxury { get; set; }

        public virtual CarLuxury CarLuxuryNavigation { get; set; }
        public virtual ICollection<ItemCars> ItemCars { get; set; }
    }
}
