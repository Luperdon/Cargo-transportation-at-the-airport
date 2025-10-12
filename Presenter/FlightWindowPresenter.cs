using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CargoTransportationAtTheAirportF.Presenter
{
    public class FlightWindowPresenter
    {
        private readonly IFlightWindow _view;
        private readonly List<Flight> _flights;
        private readonly List<Airplane> _airplanes;

        public FlightWindowPresenter(IFlightWindow view, List<Flight> flights, List<Airplane> airplanes)
        {
            _view = view;
            _flights = flights;
            _airplanes = airplanes;

            _view.ShowFlightsChartRequested += OnShowFlightsChart;
        }

        private void OnShowFlightsChart()
        {
            // проверка на нереалистичность
            var longFlights = _flights
                .Where(f => f._flightTime > 20)
                .ToList();

            if (longFlights.Any())
            {
                MessageBox.Show(
                    "Некоторые рейсы имеют длительность более 20 часов.\n" +
                    "Это может быть нереалистично при реальных условиях полёта.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            _view.ShowFlightsChart(_flights, _airplanes);
        }

    }
}
