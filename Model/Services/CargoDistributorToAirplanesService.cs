using CargoTransportationAtTheAirportF.Model.Services.Strategies.CargoDistributionToAirplanes;
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

        public int _totalUnloadedCargo { get; private set; }

        public CargoDistributorToAirplanesService(ICargoDistributionToAirplanes strategy)
        {
            _strategy = strategy;
            _totalUnloadedCargo = 0;
        }

        public void DistributeAll(List<Terminal> terminals, List<Airplane> airplanes)
        {
            foreach (var terminal in terminals)
            {
                while (terminal.cargoQueue.Count > 0)
                {
                    var cargo = terminal.cargoQueue.Dequeue();
                    bool placed = _strategy.DistributeCargoToAirplanes(cargo, airplanes);

                    if (placed)
                    {
                        foreach (var airplane in airplanes)
                        {
                            if (airplane.cargoQueue.Contains(cargo))
                            {
                                double loadingTime = airplane._minLoadingTime +
                                                     _rnd.NextDouble() * (airplane._maxLoadingTime - airplane._minLoadingTime);

                                airplane._totalLoadingTime += loadingTime;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _totalUnloadedCargo++;
                    }
                }
            }
        }
    }
}
