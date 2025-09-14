using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class CargoService
    {
        private readonly Random _rnd = new Random();

        public List<Cargo> CreateCargo(int count, double minWeight, double maxWeight) 
        {
            var cargos = new List<Cargo>();
            cargos.Clear();
            for (int i = 0; i < count; i++)
            {
                double weight = minWeight + _rnd.NextDouble() * (maxWeight - minWeight);
                cargos.Add(new Cargo(i, weight));
            }
            return cargos;
        }
    }
}
