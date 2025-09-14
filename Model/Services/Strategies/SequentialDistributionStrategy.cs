using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies
{
    public class SequentialDistributionStrategy : ICargoDistributionToTerminals
    {
        public bool DistributeCargoToTerminals(Cargo cargo, List<Terminal> terminals)
        {
            foreach (var terminal in terminals)
            {
                if (terminal.cargoQueue.Count < terminal._maxQuantityCargo && cargo._cargoWeight <= terminal._maxPassableWeight)
                {
                    terminal.cargoQueue.Enqueue(cargo);

                    terminal._currentQuantityCargo++;
                }
            }
            return false;
        }
    }
}
