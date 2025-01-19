﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoAdapter
{
    public class SensorCAdapter : ITemperatureSensor
    {
        private SensorC _sensorC = new SensorC();
        public double ReadTemperature() => _sensorC.FetchTempC();
    }
}