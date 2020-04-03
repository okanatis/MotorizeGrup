using System;
using System.Collections.Generic;

namespace MotorizeGrup_Entities.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Provinces = new HashSet<Provinces>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Provinces> Provinces { get; set; }
    }
}
