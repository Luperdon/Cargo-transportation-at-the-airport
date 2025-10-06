using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View.Interface;
using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.Presenter
{
    public class TerminalWindowPresenter
    {
        private readonly ITerminalWindow _view;
        private readonly List<Terminal> _terminals;

        public TerminalWindowPresenter(ITerminalWindow view, List<Terminal> terminals)
        {
            _view = view;
            _terminals = terminals;

            _view.ShowTerminalChartRequested += OnShowTerminalChart;
        }

        private void OnShowTerminalChart()
        {
            _view.ShowTerminalsChart(_terminals);
        }
    }
}
