using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Models
{
    public class AirQualityIndex
    {
        public int Id { get; set; }
        public IndexLevel StIndexLevel { get; set; }

        public IndexLevel So2IndexLevel { get; set; }

        public IndexLevel No2IndexLevel { get; set; }

        public IndexLevel CoIndexLevel { get; set; }

        public IndexLevel Pm10IndexLevel { get; set; }

        public IndexLevel Pm25IndexLevel { get; set; }

        public IndexLevel O3IndexLevel { get; set; }

        public IndexLevel C6H6IndexLevel { get; set; }

    }
}
