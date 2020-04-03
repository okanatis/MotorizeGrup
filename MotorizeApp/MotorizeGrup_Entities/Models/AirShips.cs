using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class AirShips
    {
        public AirShips()
        {
            AirShipExpedition = new HashSet<AirShipExpedition>();
        }

        public int AirShipsId { get; set; }
        public DateTime? FlyDate { get; set; }
        public DateTime? LandingDate { get; set; }
        public int? RoutesIdNumb { get; set; }
        public int? AirwayIdNumb { get; set; }

        public virtual AirWayCompany AirwayIdNumbNavigation { get; set; }
        public virtual AirRoutes RoutesIdNumbNavigation { get; set; }
        public virtual ICollection<AirShipExpedition> AirShipExpedition { get; set; }
    }
}
