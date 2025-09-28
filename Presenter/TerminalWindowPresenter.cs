using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Presenter
{
    public class TerminalWindowPresenter
    {
        private readonly ITerminalWindow _view;

        public TerminalWindowPresenter(ITerminalWindow view)
        {
            _view = view;
            //_view.ShowTerminalChart += OnShowTerminalChart;
        }

        private void OnShowTerminalChart(List<Terminal> obj)
        {
            throw new NotImplementedException();
        }
    }
}
