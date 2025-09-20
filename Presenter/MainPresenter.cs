using CargoTransportationAtTheAirportF.Model.Services.Strategies;
using CargoTransportationAtTheAirportF.Model.Services;
using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Presenter
{
    public class MainPresenter
    {
        private readonly IView _view;
        private readonly CargoService _cargoService;
        private readonly TerminalService _terminalService;
        public int unprocessedCargoCount { get; private set; } = 0;

        public MainPresenter(IView view)
        {
            _view = view;
            _cargoService = new CargoService();
            _terminalService = new TerminalService();

            // Подписка на событие из формы
            _view.CreateAndDistributeCargoToTerminals += OnCreateAndDistributeCargoToTerminals;
        }

        private void OnCreateAndDistributeCargoToTerminals()
        {
            // 1. Создаём грузы и терминалы
            var cargos = _cargoService.CreateCargo(
                _view.cargoCount,
                _view.minCargoWeight,
                _view.maxCargoWeight
            );

            var terminals = _terminalService.CreateTerminals(
                _view.terminalCount,
                _view.terminalMaxCapacity,
                double.MaxValue, // если хочешь учитывать maxPassableWeight, добавь поле во View
                _view.terminalMinProcessingTime,
                _view.terminalMaxProcessingTime
            );

            // 2. Определяем стратегию
            ICargoDistributionToTerminals strategy = GetStrategy(_view.selectedStrategy);

            // 3. Создаём распределитель и запускаем
            var distributor = new CargoDistributorToTerminalsService(strategy);
            distributor.DistributeAll(cargos, terminals);
            unprocessedCargoCount = distributor._totalUprocessedCargo;
            // 4. Передаём результат во View (для отображения Chart)
            _view.ShowTerminalChart(terminals);
        }

        private ICargoDistributionToTerminals GetStrategy(string strategyName)
        {
            if (strategyName == "Нормальное")
                return new NormalDistributionToTerminalsStrategy();
            else if (strategyName == "Экспоненциальное")
                return new ExponentialDistributionToTerminalsStrategy();
            else
                return new SequentialDistributionToTerminalsStrategy(); // по умолчанию
        }
    }
}
