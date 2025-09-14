using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class CargoDistributorService
    {
        private readonly ICargoDistributionToTerminals _strategy;
        private readonly Random _rnd = new Random();
        public int _totalUprocessedCargo = 0;
        public CargoDistributorService(ICargoDistributionToTerminals strategy)
        {
            _strategy = strategy;
        }

        public void DistributeAll(List<Cargo> cargos, List<Terminal> terminals)
        {
            foreach (var cargo in cargos)
            {
                var terminal = _strategy.ChooseTerminal(cargo, terminals);
                if (terminal != null)
                {
                    if (terminal._maxPassableWeight < cargo._cargoWeight)
                    {
                        // Кладём груз в очередь терминала
                        terminal.cargoQueue.Enqueue(cargo);
                        terminal._currentQuantityCargo++;

                        // Генерируем время обработки
                        double processingTime = terminal._minProcessingTime +
                            _rnd.NextDouble() * (terminal._maxProcessingTime - terminal._minProcessingTime);

                        terminal._totalProcessingTime += processingTime;
                        terminal._totalProcessedCargo++;
                    }
                    else
                    {
                        _totalUprocessedCargo++;
                    }
                }
            }
        }
    }
}
