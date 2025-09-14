using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class Cargo
    {
        public int _cargoNumber { get; set; }
        public double _cargoWeight { get; set; }

        public Cargo(int cargoNumber, double cargoWeight)
        {
            _cargoNumber = cargoNumber;
            _cargoWeight = cargoWeight;
        }
    }
}
