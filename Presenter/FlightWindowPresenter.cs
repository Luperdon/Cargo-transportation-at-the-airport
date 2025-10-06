using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View.Interface;
using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.Presenter
{
    public class FlightWindowPresenter
    {
        private readonly IFlightWindow _view;
        private readonly List<Flight> _flights;

        public FlightWindowPresenter(IFlightWindow view, List<Flight> flights)
        {
            _view = view;
            _flights = flights;

            _view.ShowFlightsChartRequested += OnShowFlightsChart;
        }

        private void OnShowFlightsChart()
        {
            _view.ShowFlightsChart(_flights);
        }
    }
}
