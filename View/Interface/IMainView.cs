using CargoTransportationAtTheAirportF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.View
{
    public interface IMainView
    {
        event Action CompleteDistribution; //переделать в полное распределение
        event Action ShowFlightsWindow;
        event Action ShowTerminalsWindow;
        event Action SaveSettingsRequested;
        event Action LoadSettingsRequested;
        int cargoCount { get; }
        double minCargoWeight { get; }
        double maxCargoWeight { get; }

        int terminalCount { get; }
        int terminalMaxCapacity { get; }
        double minProcessingTime { get; }
        double maxProcessingTime { get; }
        double maxPassableWeight { get; }
        string selectedStrategyTerminals { get; }

        int airplaneCount { get; }
        double airplaneSpeed { get; }
        double airplaneLoadCapacity { get; }
        double minLoadingTime { get; }
        double maxLoadingTime { get; }
        string selectedStrategyAirplanes { get; }

        int runwayCount { get; }

        int flightCount { get; }
        double minDistance { get; }
        double maxDistance { get; }

        void ShowAirplaneChart(List<Airplane> airplanes);
        void ShowCargoStatistics(int unprocessedCargo, int unloadedCargo);

        //загрузка
        void SetCargoCount(string value);
        void SetMinCargoWeight(string value);
        void SetMaxCargoWeight(string value);

        void SetAirplaneCount(string value);
        void SetAirplaneSpeed(string value);
        void SetAirplaneLoadCapacity(string value);
        void SetMinLoadingTime(string value);
        void SetMaxLoadingTime(string value);
        void SetSelectedStrategyAirplanes(string value);

        void SetTerminalCount(string value);
        void SetTerminalMaxCapacity(string value);
        void SetMinProcessingTime(string value);
        void SetMaxProcessingTime(string value);
        void SetMaxPassableWeight(string value);
        void SetSelectedStrategyTerminals(string value);

        void SetRunwayCount(string value);

        void SetFlightCount(string value);
        void SetMinDistance(string value);
        void SetMaxDistance(string value);
    }
}
