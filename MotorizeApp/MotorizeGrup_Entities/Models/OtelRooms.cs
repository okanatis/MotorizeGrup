using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class OtelRooms
    {
        public int RoomId { get; set; }
        public int? RoomTypeint { get; set; }
        public decimal? RoomPrice { get; set; }
        public bool? RoomIsFull { get; set; }
        public int? OteId { get; set; }

        public virtual Otels Ote { get; set; }
        public virtual OtelRoomType RoomTypeintNavigation { get; set; }
    }
}
