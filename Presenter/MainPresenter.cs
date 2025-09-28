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
        private readonly IMainView _view;
        private readonly CargoService _cargoService;
        private readonly TerminalService _terminalService;
        private readonly AirplaneService _airplaneService;
        private readonly RunwayService _runwayService;
        private readonly FlightService _flightService;
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
            var cargos = _cargoService.CreateCargo(
                _view.cargoCount,
                _view.minCargoWeight,
                _view.maxCargoWeight
            );

            var terminals = _terminalService.CreateTerminals(
                _view.terminalCount,
                _view.terminalMaxCapacity,
                _view.maxPassableWeight,
                _view.minProcessingTime,
                _view.maxProcessingTime
            );

            var airplanes = _airplaneService.CreateAirplanes(
                _view.airplaneCount,
                _view.airplaneLoadCapacity,
                _view.minLoadingTime,
                _view.maxLoadingTime,
                _view.airplaneSpeed
            );

            var runways = _runwayService.CreateRunways(_view.runwayCount);

            ICargoDistributionToTerminals strategyTerminals = GetStrategyTerminals(_view.selectedStrategyTerminals);
            ICargoDistributionToAirplanes strategyAirplanes = GetStrategyAirplanes(_view.selectedStrategyAirplanes);

            var terminalsDistributor = new CargoDistributorToTerminalsService(strategyTerminals);
            var airplanesDistributor = new CargoDistributorToAirplanesService(strategyAirplanes);
            var airplanesToRunwaysDistributor = new RunwayDistributorService();

            terminalsDistributor.DistributeAllToTerminals(cargos, terminals);
            airplanesDistributor.DistributeAllToAirplanes(terminals, airplanes);
            airplanesToRunwaysDistributor.DistributeAirplanesToRunways(airplanes, runways);

            var flightDispatcher = new FlightDispatcherService(_flightService);
            var flights = flightDispatcher.LaunchFlights(
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
            FlightStatisticsWindow flightStatisticsWindow = new FlightStatisticsWindow();
            flightStatisticsWindow.Show();
        }
        private void OnShowTerminalsWindow()
        {
            TerminalStatisticsWindow terminalsStatisticsWindow = new TerminalStatisticsWindow();
            terminalsStatisticsWindow.Show();
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
    }
}
