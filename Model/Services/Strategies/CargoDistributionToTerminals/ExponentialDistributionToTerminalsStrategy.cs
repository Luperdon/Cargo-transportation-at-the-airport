using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies
{
    public class ExponentialDistributionToTerminalsStrategy : ICargoDistributionToTerminals
    {
        private Random _rnd = new Random();

        public Terminal ChooseTerminal(Cargo cargo, List<Terminal> terminals)
        {
            var suitable = terminals
                .Where(t => t.cargoQueue.Count < t._maxQuantityCargo &&
                            cargo._cargoWeight <= t._maxPassableWeight)
                .ToList();

            if (!suitable.Any())
                return null;

            // создаём веса по экспоненте: 1/2^i
            var weights = new List<double>();
            double sum = 0;
            for (int i = 0; i < suitable.Count; i++)
            {
                double w = 1.0 / Math.Pow(2, i);
                weights.Add(w);
                sum += w;
            }

            // нормализация
            for (int i = 0; i < weights.Count; i++)
                weights[i] /= sum;

            double r = _rnd.NextDouble();
            double cumulative = 0;
            for (int i = 0; i < suitable.Count; i++)
            {
                cumulative += weights[i];
                if (r <= cumulative)
                    return suitable[i];
            }

            return suitable.Last(); // на случай погрешности
        }
    }
}
