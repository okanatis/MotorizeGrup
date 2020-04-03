using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class AirRoutes
    {
        public AirRoutes()
        {
            AirShips = new HashSet<AirShips>();
        }

        public int RoutesId { get; set; }
        public int? RoutesFromId { get; set; }
        public int? RoutesToId { get; set; }

        public virtual District RoutesFrom { get; set; }
        public virtual District RoutesTo { get; set; }
        public virtual ICollection<AirShips> AirShips { get; set; }
    }
}
