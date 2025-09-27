using CargoTransportationAtTheAirportF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.View
{
    public interface IView
    {
        event Action CreateAndDistributeCargoToTerminals; //переделать в полное распределение по терминалам, потом по самолётам и
        //event Action ShowAirplanesChart;
        //event Action ShowFlightsWindow;
        //event Action ShowTerminalWindow;
        int cargoCount { get; }
        double minCargoWeight { get; }
        double maxCargoWeight { get; }

        int terminalCount { get; }
        int terminalMaxCapacity { get; }
        double terminalMinProcessingTime { get; }
        double terminalMaxProcessingTime { get; }

        int airplaneCount { get; }
        double airplaneSpeed { get; }

        string selectedStrategyTerminals { get; }
        string selectedStrategyAirplanes { get; }

        void ShowTerminalChart(List<Terminal> terminals);
    }
}
