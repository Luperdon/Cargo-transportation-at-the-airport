using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies
{
    public class ExponentialDistributionToAirplanesStrategy : ICargoDistributionToAirplanes
    {
        private readonly Random _rnd = new Random();

        public Airplane ChooseAirplane(Cargo cargo, List<Airplane> airplanes)
        {
            var suitable = airplanes
                .Where(a => a._currentLoad + cargo._cargoWeight <= a._loadCapacity)
                .ToList();

            if (!suitable.Any()) return null;

            var weights = new List<double>();
            double sum = 0;

            for (int i = 0; i < suitable.Count; i++)
            {
                double w = 1.0 / Math.Pow(2, i);
                weights.Add(w);
                sum += w;
            }

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

            return suitable.Last(); // на всякий случай
        }
    }
}
