using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies
{
    public class NormalDistributionToTerminalsStrategy : ICargoDistributionToTerminals
    {
        private readonly Random _rnd = new Random();

        public Terminal ChooseTerminal(Cargo cargo, List<Terminal> terminals)
        {
            var suitable = terminals
                .Where(t => t.cargoQueue.Count < t._maxQuantityCargo &&
                            cargo._cargoWeight <= t._maxPassableWeight)
                .ToList();

            if (!suitable.Any()) return null;

            int minQueueCount = suitable.Min(t => t.cargoQueue.Count);
            var candidates = suitable.Where(t => t.cargoQueue.Count == minQueueCount).ToList();

            int index = _rnd.Next(candidates.Count);
            return candidates[index];
        }
    }
}
