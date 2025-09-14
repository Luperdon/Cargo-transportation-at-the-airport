using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies
{
    public class NormalDistributionToTerminalsStrategy : ICargoDistributionToTerminals
    {
        public Terminal ChooseTerminal(Cargo cargo, List<Terminal> terminals)
        {
            var suitable = terminals
                .Where(t => t.cargoQueue.Count < t._maxQuantityCargo &&
                            cargo._cargoWeight <= t._maxPassableWeight)
                .OrderBy(t => t.cargoQueue.Count)
                .FirstOrDefault();

            return suitable;
        }
    }
}
