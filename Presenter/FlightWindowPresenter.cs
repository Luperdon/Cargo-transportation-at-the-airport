using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Presenter
{
    public class FlightWindowPresenter
    {
        private readonly IFlightWindow _view;

        public FlightWindowPresenter(IFlightWindow view)
        {
            _view = view;
            //_view.ShowFlightChart += OnShowFlightChart;
        }

        private void OnShowFlightChart(List<Airplane> obj)
        {
            throw new NotImplementedException();
        }
    }
}
