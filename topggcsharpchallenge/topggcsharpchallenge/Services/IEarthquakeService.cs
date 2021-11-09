﻿using System;
using System.Collections.Generic;
using topggcsharpchallenge.Models;

namespace topggcsharpchallenge.Services
{
    public interface IEarthquakeService
    {
        IEnumerable<EarthquakeResponseModel> Get(int latitude, int longitude, DateTime startDate, DateTime endDate);
    }
}