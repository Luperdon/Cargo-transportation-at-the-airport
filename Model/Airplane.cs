using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class Airplane
    {
        public int _airplaneNumber { get; set; }
        public double _loadCapacity { get; set; }
        public double _currentLoad { get; set; }
        public double _totalLoadingTime { get; set; }
        public Queue<Cargo> cargoQueue { get; }

        public Airplane(int airplaneNumber, double loadCapacity)
        {
            _airplaneNumber = airplaneNumber;
            _loadCapacity = loadCapacity;
            _currentLoad = 0;
            _totalLoadingTime = 0;
            cargoQueue = new Queue<Cargo>();
        }
    }
}
