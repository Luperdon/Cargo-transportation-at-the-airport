using CargoTransportationAtTheAirportF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.View.Interface
{
    public interface ITerminalWindow
    {
        void ShowTerminalChart(List<Terminal> terminals);
    }
}
