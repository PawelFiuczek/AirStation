using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Models
{
    public class MeasurementData
    {
        public string Key { get; set; }
        public List<Values> Values { get; set; }
    }
}
