using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class RunwayDistributorService
    {
        public void DistributeAirplanesToRunways(List<Airplane> airplanes, List<Runway> runways)
        {
            for (int i = 0; i < airplanes.Count; i++)
            {
                int runwayIndex = i % runways.Count;
                runways[runwayIndex].AssignAirplane(airplanes[i]);
            }
        }
    }
}