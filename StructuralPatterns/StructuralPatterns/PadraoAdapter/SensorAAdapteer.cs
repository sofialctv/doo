using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoAdapter
{
    public class SensorAAdapter : ITemperatureSensor
    {
        private SensorA _sensorA = new SensorA();
        public double ReadTemperature() => _sensorA.GetTemperatureInCelsius();
    }
}
