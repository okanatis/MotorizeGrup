using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class AirShipExpedition
    {
        public AirShipExpedition()
        {
            AirShipTickets = new HashSet<AirShipTickets>();
        }

        public int ExpeditionId { get; set; }
        public int? ExpeditionClass { get; set; }
        public bool? IsFull { get; set; }
        public int? SeatCount { get; set; }
        public decimal? Price { get; set; }
        public int? AirShipsIdNumb { get; set; }

        public virtual AirSeatType ExpeditionClass1 { get; set; }
        public virtual AirShips ExpeditionClassNavigation { get; set; }
        public virtual ICollection<AirShipTickets> AirShipTickets { get; set; }
    }
}
