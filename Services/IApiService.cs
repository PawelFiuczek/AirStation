using AirStation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public interface IApiService
    {
        Task<List<MeasuringStation>> GetStationsAsync();
        Task<List<MeasuringStation>> GetStationsByCityAsync(string cityName);
        Task<MeasuringStation> GetStationsByIdAsync(int stationId);
        Task<List<TestStand>> GetTestStandsAsync(int stationId);
        Task<MeasurementData> GetSensorDataAsync(int sensorId);
        Task<AirQualityIndex> GetAirQualityAsync(int stationId);
    }
}
