using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies
{
    public class SequentialDistributionToAirplanesStrategy : ICargoDistributionToAirplanes
    {
        public Airplane ChooseAirplane(Cargo cargo, List<Airplane> airplanes)
        {
            foreach (var airplane in airplanes)
            {
                if (airplane._currentLoad + cargo._cargoWeight <= airplane._loadCapacity)
                    return airplane;
            }
            return null;
        }
    }
}
