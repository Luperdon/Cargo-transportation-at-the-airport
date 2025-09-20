using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class Runway
    {
        public int RunwayNumber { get; set; }
        public Queue<Airplane> Airplanes { get; set; } = new Queue<Airplane>();

        public Runway(int runwayNumber)
        {
            RunwayNumber = runwayNumber;
        }

        public void AssignAirplane(Airplane airplane)
        {
            Airplanes.Enqueue(airplane);
        }

        public Airplane ReleaseAirplane()
        {
            return Airplanes.Count > 0 ? Airplanes.Dequeue() : null;
        }
    }
}
