using AirStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public interface IStationService
    {
        Task<List<MeasuringStation>> GetStationsAsync();
        Task<List<MeasuringStation>> GetStationsByCityAsync(string cityName);
        Task<MeasuringStation> GetStationsByIdAsync(int stationId);
    }
}
