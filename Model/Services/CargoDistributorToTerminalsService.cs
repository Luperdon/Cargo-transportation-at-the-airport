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

        // Публичные свойства
        public int TotalUnprocessedCargo { get; private set; } = 0;

        // Очередь ожидания
        public Queue<Cargo> WaitingQueue { get; private set; } = new Queue<Cargo>();

        public CargoDistributorToTerminalsService(ICargoDistributionToTerminals strategy)
        {
            _strategy = strategy;
        }

        public void DistributeAllToTerminals(List<Cargo> cargos, List<Terminal> terminals)
        {
            foreach (var cargo in cargos)
            {
                var terminal = _strategy.ChooseTerminal(cargo, terminals);
                if (terminal != null)
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
                    }
                    else
                    {
                        WaitingQueue.Enqueue(cargo); // кладём в очередь ожидания
                    }
                }
                else
                {
                    WaitingQueue.Enqueue(cargo); // стратегия вернула null
                }
            }

            // После первой попытки перераспределяем из очереди ожидания
            TryDistributeWaitingQueue(terminals);
        }

        private void TryDistributeWaitingQueue(List<Terminal> terminals)
        {
            int attempts = WaitingQueue.Count;
            for (int i = 0; i < attempts; i++)
            {
                var cargo = WaitingQueue.Dequeue();
                var terminal = _strategy.ChooseTerminal(cargo, terminals);

                if (terminal != null && cargo._cargoWeight <= terminal._maxPassableWeight &&
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
                    // если снова не удалось — возвращаем в очередь ожидания
                    WaitingQueue.Enqueue(cargo);
                }
            }

            // Всё, что осталось в WaitingQueue, считается необработанным
            TotalUnprocessedCargo += WaitingQueue.Count;
            WaitingQueue.Clear();
        }
    }

}
