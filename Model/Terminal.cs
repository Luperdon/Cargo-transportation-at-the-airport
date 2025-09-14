using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class Terminal
    {
        public int _terminalNumber { get; set; }
        public Queue<Cargo> cargoQueue { get; }
        public int _maxQuantityCargo { get; set; }
        public int _currentQuantityCargo { get; set; }
        public double _maxPassableWeight { get; set; }
        public double _currentWeight { get; set; }
        public double _minProcessingTime { get; set; }
        public double _maxProcessingTime { get; set; }
        public double _totalProcessingTime { get; set; }
        public int _totalProcessedCargo { get; set; }

        public Terminal(int terminalNumber, int maxQuantityCargo, double maxPassableWeight, double minProcessingTime, double maxProcessingTime)
        {
            _terminalNumber = terminalNumber;
            cargoQueue = new Queue<Cargo>();
            _maxQuantityCargo = maxQuantityCargo;
            _currentQuantityCargo = 0;
            _maxPassableWeight = maxPassableWeight;
            _currentWeight = 0;
            _minProcessingTime = minProcessingTime;
            _maxProcessingTime = maxProcessingTime;
        }
    }
}
