using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class Airports
    {
        public Airports()
        {
            ItemCars = new HashSet<ItemCars>();
        }

        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public int? DiscId { get; set; }

        public virtual District Disc { get; set; }
        public virtual ICollection<ItemCars> ItemCars { get; set; }
    }
}
