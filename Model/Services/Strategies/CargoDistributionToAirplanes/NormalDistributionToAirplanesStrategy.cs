using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies.CargoDistributionToAirplanes
{
    public class NormalDistributionToAirplanesStrategy : ICargoDistributionToAirplanes
    {
        public bool DistributeCargoToAirplanes(Cargo cargo, List<Airplane> airplanes)
        {
            var suitable = airplanes
                .Where(a => a._currentLoad + cargo._cargoWeight <= a._loadCapacity)
                .OrderBy(a => a._cargoQuantity)
                .FirstOrDefault();

            if (suitable != null)
            {
                suitable.cargoQueue.Enqueue(cargo);
                suitable._currentLoad += cargo._cargoWeight;
                suitable._cargoQuantity++;
                return true;
            }
            return false;
        }
    }
}
