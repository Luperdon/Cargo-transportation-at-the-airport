using CargoTransportationAtTheAirportF.Model.Services.Strategies;
using System;
using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class CargoDistributorToAirplanesService
    {
        private readonly ICargoDistributionToAirplanes _strategy;
        private readonly Random _rnd = new Random();

        public int TotalUnloadedCargo { get; private set; } = 0;
        public int TotalBrokenCargo { get; private set; } = 0;

        private readonly double _globalBreakProbability;

        public CargoDistributorToAirplanesService(ICargoDistributionToAirplanes strategy, double globalBreakProbability = 0.0)
        {
            _strategy = strategy;
            _globalBreakProbability = Math.Max(0.0, Math.Min(1.0, globalBreakProbability));
        }

        private bool CheckIfBroken(Cargo cargo)
        {
            double p = cargo.BreakProbability > 0 ? cargo.BreakProbability : _globalBreakProbability;
            if (p <= 0) return false;
            return _rnd.NextDouble() < p;
        }

        public void DistributeAllToAirplanes(List<Terminal> terminals, List<Airplane> airplanes)
        {
            foreach (var terminal in terminals)
            {
                while (terminal.cargoQueue.Count > 0)
                {
                    var cargo = terminal.cargoQueue.Dequeue();

                    if (CheckIfBroken(cargo))
                    {
                        cargo.IsBroken = true;
                        TotalBrokenCargo++;
                        continue;
                    }

                    bool loaded = false;

                    foreach (var airplane in airplanes)
                    {
                        if (airplane._currentLoad + cargo._cargoWeight <= airplane._loadCapacity)
                        {
                            airplane.cargoQueue.Enqueue(cargo);
                            airplane._currentLoad += cargo._cargoWeight;
                            airplane._cargoQuantity++;

                            double loadingTime = airplane._minLoadingTime +
                                                 _rnd.NextDouble() * (airplane._maxLoadingTime - airplane._minLoadingTime);
                            airplane._totalLoadingTime += loadingTime;

                            loaded = true;
                            break;
                        }
                    }

                    if (!loaded)
                    {
                        TotalUnloadedCargo++;
                    }
                }
            }
        }

        public void DistributeStep(List<Terminal> terminals, List<Airplane> airplanes)
        {
            foreach (var terminal in terminals)
            {
                if (terminal.cargoQueue.Count > 0)
                {
                    var cargo = terminal.cargoQueue.Dequeue();

                    if (CheckIfBroken(cargo))
                    {
                        cargo.IsBroken = true;
                        TotalBrokenCargo++;
                        continue;
                    }

                    var airplane = _strategy.ChooseAirplane(cargo, airplanes);

                    if (airplane != null &&
                        airplane._currentLoad + cargo._cargoWeight <= airplane._loadCapacity)
                    {
                        airplane.cargoQueue.Enqueue(cargo);
                        airplane._currentLoad += cargo._cargoWeight;
                        airplane._cargoQuantity++;

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
