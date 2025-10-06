using CargoTransportationAtTheAirportF.Model;
using System;
using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.View.Interface
{
    public interface ITerminalWindow
    {
        event Action ShowTerminalChartRequested;
        void ShowTerminalsChart(List<Terminal> terminals);
    }
}
