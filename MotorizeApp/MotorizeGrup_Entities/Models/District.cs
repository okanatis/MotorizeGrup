using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class District
    {
        public District()
        {
            AirRoutesRoutesFrom = new HashSet<AirRoutes>();
            AirRoutesRoutesTo = new HashSet<AirRoutes>();
            Airports = new HashSet<Airports>();
            Otels = new HashSet<Otels>();
            Restauranties = new HashSet<Restauranties>();
        }

        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string CustomDisctName { get; set; }
        public int? ProvId { get; set; }

        public virtual Provinces Prov { get; set; }
        public virtual ICollection<AirRoutes> AirRoutesRoutesFrom { get; set; }
        public virtual ICollection<AirRoutes> AirRoutesRoutesTo { get; set; }
        public virtual ICollection<Airports> Airports { get; set; }
        public virtual ICollection<Otels> Otels { get; set; }
        public virtual ICollection<Restauranties> Restauranties { get; set; }
    }
}
