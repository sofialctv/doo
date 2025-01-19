using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.PadraoAdapter
{
    public class SensorBAdapter : ITemperatureSensor
    {
        private SensorB _sensorB = new SensorB();
        public double ReadTemperature() => _sensorB.ObtenerTemperaturaEnCentigrados();
    }
}
