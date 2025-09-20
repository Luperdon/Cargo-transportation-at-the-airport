using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class RunwayService
    {
        public List<Runway> CreateRunways(int runwayCount, List<Airplane> airplanes)
        {
            var runways = new List<Runway>();

            // создаём полосы
            for (int i = 0; i < runwayCount; i++)
                runways.Add(new Runway(i));

            // распределяем самолёты по полосам циклически
            for (int i = 0; i < airplanes.Count; i++)
            {
                int runwayIndex = i % runwayCount;
                runways[runwayIndex].AssignAirplane(airplanes[i]);
            }

            return runways;
        }
    }
}
