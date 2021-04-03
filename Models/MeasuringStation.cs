using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Models
{
    public class MeasuringStation
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public double GegrLat { get; set; }
        public double GegrLon { get; set; }
        public City City { get; set; }
        public string AddressStreet { get; set; }
        public List<TestStand> TestStands { get; set; }
        public AirQualityIndex AirQualityIndex { get; set; }
    }
}
