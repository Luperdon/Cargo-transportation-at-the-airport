using CargoTransportationAtTheAirportF.Model.Services.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class CargoDistributorToAirplanesService
    {
        private readonly ICargoDistributionToAirplanes _strategy;
        private readonly Random _rnd = new Random();

        public int TotalUnloadedCargo { get; private set; } = 0;

        public CargoDistributorToAirplanesService(ICargoDistributionToAirplanes strategy)
        {
            _strategy = strategy;
        }

        public void DistributeAllToAirplanes(List<Terminal> terminals, List<Airplane> airplanes)
        {
            foreach (var terminal in terminals)
            {
                while (terminal.cargoQueue.Count > 0)
                {
                    var cargo = terminal.cargoQueue.Dequeue();

                    // получаем самолёт сразу
                    var airplane = _strategy.ChooseAirplane(cargo, airplanes);

                    if (airplane != null)
                    {
                        airplane.cargoQueue.Enqueue(cargo);
                        airplane._currentLoad += cargo._cargoWeight;
                        airplane._cargoQuantity++;

                        // время погрузки
                        double loadingTime = airplane._minLoadingTime +
                                             _rnd.NextDouble() * (airplane._maxLoadingTime - airplane._minLoadingTime);
                        airplane._totalLoadingTime += loadingTime;
                    }
                    else
                    {
                        TotalUnloadedCargo++;
                    }
                }
            }
        }
    }
}
