using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies
{
    public class NormalDistributionStrategy : ICargoDistributionToTerminals
    {
        public bool DistributeCargoToTerminals(Cargo cargo, List<Terminal> terminals)
        {
            var suitable = terminals
            .Where(t => t.cargoQueue.Count < t._maxQuantityCargo && cargo._cargoWeight <= t._maxPassableWeight)
            .OrderBy(t => t.cargoQueue.Count)
            .FirstOrDefault();
            if (suitable != null)
            {
                suitable.cargoQueue.Enqueue(cargo);

                suitable._currentQuantityCargo++;
                return true;
            }
            return false;
        }
    }
}
