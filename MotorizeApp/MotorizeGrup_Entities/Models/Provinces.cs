using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class Provinces
    {
        public Provinces()
        {
            District = new HashSet<District>();
        }

        public int ProvinceId { get; set; }
        public string ProvName { get; set; }
        public int? ContId { get; set; }

        public virtual Countries Cont { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}
