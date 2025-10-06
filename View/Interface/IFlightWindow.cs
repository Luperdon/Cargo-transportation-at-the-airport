using CargoTransportationAtTheAirportF.Model;
using System;
using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.View.Interface
{
    public interface IFlightWindow
    {
        event Action ShowFlightsChartRequested;

        void ShowFlightsChart(List<Flight> flights);
    }
}
