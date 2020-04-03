using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class Otels
    {
        public Otels()
        {
            OtelRooms = new HashSet<OtelRooms>();
            Photos = new HashSet<Photos>();
        }

        public int OtelId { get; set; }
        public string OtelName { get; set; }
        public string OtelAddress { get; set; }
        public int? OtelTypeId { get; set; }
        public int? OtelDistrictId { get; set; }
        public int? OtelFacilitiesId { get; set; }

        public virtual District OtelDistrict { get; set; }
        public virtual Facilities OtelFacilities { get; set; }
        public virtual OtelTypes OtelType { get; set; }
        public virtual ICollection<OtelRooms> OtelRooms { get; set; }
        public virtual ICollection<Photos> Photos { get; set; }
    }
}
