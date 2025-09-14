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
        event Action CreateAndDistributeCargoToTerminals;
        int cargoCount { get; }
        double minCargoWeight { get; }
        double maxCargoWeight { get; }

        int terminalCount { get; }
        int terminalMaxCapacity { get; }
        double terminalMinProcessingTime { get; }
        double terminalMaxProcessingTime { get; }

        string selectedStrategy { get; }

        void ShowTerminalChart(List<Terminal> terminals);
    }
}
