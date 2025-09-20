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
        public int _cargoQuantity { get; set; }
        public double _loadCapacity { get; set; }
        public double _currentLoad { get; set; }
        public double _totalLoadingTime { get; set; }
        public double _minLoadingTime { get; set; }
        public double _maxLoadingTime { get; set; }
        public double _totalFlightTime { get; set; }
        public double _airplaneSpeed { get; set; }
        public Queue<Cargo> cargoQueue { get; }

        public Airplane(int airplaneNumber, double loadCapacity, double minLoadingTime, double maxLoadingTime, double airplaneSpeed)
        {
            _airplaneNumber = airplaneNumber;
            _loadCapacity = loadCapacity;
            _cargoQuantity = 0;
            _currentLoad = 0;
            _totalLoadingTime = 0;
            _minLoadingTime = minLoadingTime;
            _maxLoadingTime = maxLoadingTime;
            _totalFlightTime = 0;
            cargoQueue = new Queue<Cargo>();
            _airplaneSpeed = airplaneSpeed;
        }
    }
}
