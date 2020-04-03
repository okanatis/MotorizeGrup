using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class OtelRoomType
    {
        public OtelRoomType()
        {
            OtelRooms = new HashSet<OtelRooms>();
        }

        public int OtelRoomTypeId { get; set; }
        public string OtelRoomTypeName { get; set; }

        public virtual ICollection<OtelRooms> OtelRooms { get; set; }
    }
}
