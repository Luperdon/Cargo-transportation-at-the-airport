using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class AirplaneService
    {
        public List<Airplane> CreateAirplanes(int count, double loadCapacity, double minLoadingTime, double maxLoadingTime)
        {
            var airplanes = new List<Airplane>();
            for (int i = 0; i < count; i++)
            {
                airplanes.Add(new Airplane(i, loadCapacity, minLoadingTime, maxLoadingTime));
            }
            return airplanes;
        }
    }
}
