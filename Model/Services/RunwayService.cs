using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class RunwayService
    {
        public List<Runway> CreateRunways(int runwayCount)
        {
            var runways = new List<Runway>();
            for (int i = 0; i < runwayCount; i++)
                runways.Add(new Runway(i));

            return runways;
        }
    }
}