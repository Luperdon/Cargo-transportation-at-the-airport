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
    }
}
