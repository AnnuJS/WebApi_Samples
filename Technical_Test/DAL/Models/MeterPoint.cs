using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MeterPoint
    {
        public string Mpan { get; set; } //Assuming that this is PK as it has unique values in data given
        public string MpanIndicator { get; set; }
        public virtual ICollection<Meter> Meters { get; set; } //In database we could have a relationship table with PKs from Meter and MeterPoint tables

    }
}
