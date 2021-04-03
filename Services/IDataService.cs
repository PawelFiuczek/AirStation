﻿using AirStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public interface IDataService
    {
        Task<MeasurementData> GetSensorDataAsync(int sensorId);
    }
}
