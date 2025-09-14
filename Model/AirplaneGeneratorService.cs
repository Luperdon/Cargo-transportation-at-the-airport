using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class AirplaneGeneratorService
    {
        private readonly Random _rnd = new Random();
        public List<Airplane> AirplanesGenerate(int count, double minLoadTime, double maxLoadTime, double loadCapacity)
        {
            var airplanes = new List<Airplane>();
            for (int i = 0; i < count; i++)
            {
                double cargoLoadingTime = minLoadTime + _rnd.NextDouble() * (maxLoadTime - minLoadTime);
                airplanes.Add(new Airplane(i, cargoLoadingTime));
            }
            return airplanes;
        }
    }
}
