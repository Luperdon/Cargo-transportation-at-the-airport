using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class CargoDistributorToTerminalsService
    {
        private readonly ICargoDistributionToTerminals _strategy;
        private readonly Random _rnd = new Random();

        public int TotalUnprocessedCargo { get; private set; } = 0;

        public Queue<Cargo> WaitingQueue { get; private set; } = new Queue<Cargo>();

        public CargoDistributorToTerminalsService(ICargoDistributionToTerminals strategy)
        {
            _strategy = strategy;
        }

        public void DistributeAllToTerminals(List<Cargo> cargos, List<Terminal> terminals)
        {
            foreach (var cargo in cargos)
            {
                bool assigned = false;

                foreach (var terminal in terminals)
                {
                    if (cargo._cargoWeight <= terminal._maxPassableWeight &&
                        terminal.cargoQueue.Count < terminal._maxQuantityCargo)
                    {
                        terminal.cargoQueue.Enqueue(cargo);
                        terminal._currentQuantityCargo++;

                        double processingTime = terminal._minProcessingTime +
                                                _rnd.NextDouble() * (terminal._maxProcessingTime - terminal._minProcessingTime);
                        terminal._totalProcessingTime += processingTime;
                        terminal._totalProcessedCargo++;

                        assigned = true;
                        break;
                    }
                }

                if (!assigned)
                {
                    TotalUnprocessedCargo++;
                }
            }
        }


        public void TryDistributeSingleCargo(Cargo cargo, List<Terminal> terminals)
        {
            var terminal = _strategy.ChooseTerminal(cargo, terminals);

            if (terminal != null &&
                cargo._cargoWeight <= terminal._maxPassableWeight &&
                terminal.cargoQueue.Count < terminal._maxQuantityCargo)
            {
                terminal.cargoQueue.Enqueue(cargo);
                terminal._currentQuantityCargo++;

                double processingTime = terminal._minProcessingTime +
                                        _rnd.NextDouble() * (terminal._maxProcessingTime - terminal._minProcessingTime);
                terminal._totalProcessingTime += processingTime;
                terminal._totalProcessedCargo++;
            }
            else
            {
                TotalUnprocessedCargo++;
            }
        }
    }
}
