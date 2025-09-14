using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies.CargoDistributionToAirplanes
{
    public class SequentialDistributionToAirplanesStrategy : ICargoDistributionToAirplanes
    {
        public bool DistributeCargoToAirplanes(Cargo cargo, List<Airplane> airplanes)
        {
            foreach (var airplane in airplanes)
            {
                if (airplane._currentLoad + cargo._cargoWeight <= airplane._loadCapacity)
                {
                    airplane.cargoQueue.Enqueue(cargo);
                    airplane._currentLoad += cargo._cargoWeight;
                    airplane._cargoQuantity++;
                    return true;
                }
            }
            return false;
        }
    }
}
