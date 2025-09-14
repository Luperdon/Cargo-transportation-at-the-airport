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

        public Terminal(int terminalNumber, int maxQuantityCargo, double maxPassableWeight)
        {
            _terminalNumber = terminalNumber;
            cargoQueue = new Queue<Cargo>();
            _maxQuantityCargo = maxQuantityCargo;
            _currentQuantityCargo = 0;
            _maxPassableWeight = maxPassableWeight;
            _currentWeight = 0;
        }
    }
}
