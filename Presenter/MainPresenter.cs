using CargoTransportationAtTheAirportF.Model.Services.Strategies;
using CargoTransportationAtTheAirportF.Model.Services;
using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoTransportationAtTheAirportF.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly CargoService _cargoService;
        private readonly TerminalService _terminalService;
        private readonly AirplaneService _airplaneService;
        private readonly RunwayService _runwayService;
        private readonly FlightService _flightService;

        private Queue<Cargo> cargos;
        private List<Terminal> terminals;
        private List<Flight> flights;
        private List<Airplane> airplanes;
        private List<Runway> runways;

        public int unprocessedCargoCount { get; private set; } = 0;
        public int unloadedCargoCount { get; private set; } = 0;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _cargoService = new CargoService();
            _terminalService = new TerminalService();
            _airplaneService = new AirplaneService();
            _runwayService = new RunwayService();
            _flightService = new FlightService();

            // Подписка на событие из формы
            _view.CompleteDistribution += OnCompleteDistribution;
            _view.ShowFlightsWindow += OnShowFlightsWindow;
            _view.ShowTerminalsWindow += OnShowTerminalsWindow;
        }

        private void OnCompleteDistribution()
        {
            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cargos = new Queue<Cargo>(_cargoService.CreateCargo(
                _view.cargoCount,
                _view.minCargoWeight,
                _view.maxCargoWeight
            ));


            terminals = _terminalService.CreateTerminals(
                _view.terminalCount,
                _view.terminalMaxCapacity,
                _view.maxPassableWeight,
                _view.minProcessingTime,
                _view.maxProcessingTime
            );

            airplanes = _airplaneService.CreateAirplanes(
                _view.airplaneCount,
                _view.airplaneLoadCapacity,
                _view.minLoadingTime,
                _view.maxLoadingTime,
                _view.airplaneSpeed
            );

            runways = _runwayService.CreateRunways(_view.runwayCount);

            ICargoDistributionToTerminals strategyTerminals = GetStrategyTerminals(_view.selectedStrategyTerminals);
            ICargoDistributionToAirplanes strategyAirplanes = GetStrategyAirplanes(_view.selectedStrategyAirplanes);

            var terminalsDistributor = new CargoDistributorToTerminalsService(strategyTerminals);
            var airplanesDistributor = new CargoDistributorToAirplanesService(strategyAirplanes);
            var airplanesToRunwaysDistributor = new RunwayDistributorService();

            //terminalsDistributor.DistributeAllToTerminals(cargos, terminals);
            //airplanesDistributor.DistributeAllToAirplanes(terminals, airplanes);
            //airplanesToRunwaysDistributor.DistributeAirplanesToRunways(airplanes, runways);

            while (cargos.Any() || terminals.Any(t => t.cargoQueue.Count > 0))
            {
                // шаг 1: пробуем направить новые грузы в терминалы
                if (cargos.Any())
                {
                    var newCargo = cargos.Dequeue();
                    terminalsDistributor.TryDistributeSingleCargo(newCargo, terminals);
                }

                // шаг 2: терминалы отдают грузы в самолёты
                airplanesDistributor.DistributeStep(terminals, airplanes);
            }

            //airplanesToRunwaysDistributor.DistributeAirplanesToRunways(runways, airplanes);

            var flightDispatcher = new FlightDispatcherService(_flightService);
            flights = flightDispatcher.LaunchFlights(
                runways,
                _view.flightCount,
                _view.minDistance,
                _view.maxDistance
            );

            unprocessedCargoCount = terminalsDistributor.TotalUnprocessedCargo;
            unloadedCargoCount = airplanesDistributor.TotalUnloadedCargo;

            _view.ShowAirplaneChart(airplanes);
            _view.ShowCargoStatistics(unprocessedCargoCount, unloadedCargoCount);
        }

        private void OnShowFlightsWindow()
        {
            if(flights != null)
            {
                var flightStatisticsWindow = new FlightStatisticsWindow();
                var presenter = new FlightWindowPresenter(flightStatisticsWindow, flights);
                flightStatisticsWindow.Show();
            }
            else
            {
                MessageBox.Show("Полёты ещё не созданы, сначала нажмите кнопку Старт", "Ошибка");
            }
        }

        private void OnShowTerminalsWindow()
        {
            if(terminals != null)
            {
                var terminalStatisticsWindow = new TerminalStatisticsWindow();
                var presenter = new TerminalWindowPresenter(terminalStatisticsWindow, terminals);
                terminalStatisticsWindow.Show();
            }
            else
            {
                MessageBox.Show("Терминалы ещё не созданы, сначала нажмите кнопку Старт", "Ошибка");
            }
        }

        private ICargoDistributionToTerminals GetStrategyTerminals(string strategyTerminalsName)
        {
            if (strategyTerminalsName == "Нормальное")
                return new NormalDistributionToTerminalsStrategy();
            else if (strategyTerminalsName == "Экспоненциальное")
                return new ExponentialDistributionToTerminalsStrategy();
            else
                return new SequentialDistributionToTerminalsStrategy(); // по умолчанию
        }
        private ICargoDistributionToAirplanes GetStrategyAirplanes(string strategyAirplanesName)
        {
            if (strategyAirplanesName == "Нормальное")
                return new NormalDistributionToAirplanesStrategy();
            else if (strategyAirplanesName == "Экспоненциальное")
                return new ExponentialDistributionToAirplanesStrategy();
            else
                return new SequentialDistributionToAirplanesStrategy(); // по умолчанию
        }

        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = "";

            try
            {
                if (_view.cargoCount <= 0)
                    errorMessage += "Количество грузов должно быть больше 0.\n";
                if (_view.minCargoWeight <= 0 || _view.maxCargoWeight <= 0)
                    errorMessage += "Вес грузов должен быть больше 0.\n";
                if (_view.minCargoWeight > _view.maxCargoWeight)
                    errorMessage += "Минимальный вес не может быть больше максимального.\n";

                if (_view.airplaneCount <= 0)
                    errorMessage += "Количество самолётов должно быть больше 0.\n";
                if (_view.airplaneLoadCapacity <= 0)
                    errorMessage += "Грузоподъёмность самолётов должна быть больше 0.\n";
                if (_view.minLoadingTime < 0 || _view.maxLoadingTime < 0)
                    errorMessage += "Время погрузки не может быть отрицательным.\n";
                if (_view.minLoadingTime > _view.maxLoadingTime)
                    errorMessage += "Минимальное время погрузки больше максимального.\n";
                if (_view.airplaneSpeed <= 0)
                    errorMessage += "Скорость самолётов должна быть больше 0.\n";

                if (_view.terminalCount <= 0)
                    errorMessage += "Количество терминалов должно быть больше 0.\n";
                if (_view.terminalMaxCapacity <= 0)
                    errorMessage += "Вместимость терминала должна быть больше 0.\n";
                if (_view.minProcessingTime < 0 || _view.maxProcessingTime < 0)
                    errorMessage += "Время обработки не может быть отрицательным.\n";
                if (_view.minProcessingTime > _view.maxProcessingTime)
                    errorMessage += "Минимальное время обработки больше максимального.\n";
                if (_view.maxPassableWeight <= 0)
                    errorMessage += "Максимальный пропускаемый вес должен быть больше 0.\n";

                if (_view.runwayCount <= 0)
                    errorMessage += "Количество взлётно-посадочных полос должно быть больше 0.\n";

                if (_view.flightCount <= 0)
                    errorMessage += "Количество рейсов должно быть больше 0.\n";
                if (_view.minDistance < 0 || _view.maxDistance < 0)
                    errorMessage += "Дистанция не может быть отрицательной.\n";
                if (_view.minDistance > _view.maxDistance)
                    errorMessage += "Минимальная дистанция больше максимальной.\n";

                return string.IsNullOrEmpty(errorMessage); // true, если ошибок нет
            }
            catch (Exception ex)
            {
                errorMessage = "Ошибка при проверке данных: " + ex.Message;
                return false;
            }
        }
    }
}
