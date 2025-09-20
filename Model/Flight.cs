using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class Flight
    {
        public int _flightNumber { get; set; }
        public double _distance { get; set; }
        public Airplane _airplane { get; set; }
        public Runway _runway { get; set; }
        public double _flightTime { get; set; }


        public Flight(int flightNumber, double distance, Airplane airplane, Runway runway)
        {
            _flightNumber = flightNumber;
            _distance = distance;
            _airplane = airplane;
            _runway = runway;

            _flightTime = distance / airplane._airplaneSpeed;
            _airplane._totalFlightTime += _flightTime;
        }
    }
}
