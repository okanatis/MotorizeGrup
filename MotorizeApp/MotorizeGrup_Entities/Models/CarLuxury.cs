using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class CarLuxury
    {
        public CarLuxury()
        {
            Cars = new HashSet<Cars>();
        }

        public int LuxId { get; set; }
        public string LuxName { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
    }
}
