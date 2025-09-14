using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class Runway
    {
        public int _runwayNumber { get; set; }
        public bool _isBusy { get; set; }
        public Queue<Airplane> airplaneQueue { get; }

        public Runway(int runwayNumber)
        {
            _runwayNumber = runwayNumber;
            _isBusy = false;
            airplaneQueue = new Queue<Airplane>();
        }
    }
}
