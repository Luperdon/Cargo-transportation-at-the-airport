using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model
{
    public class TerminalService
    {
        public List<Terminal> CreateTerminals(int count, int maxQuantityCargo, double maxPassableWeight, double minProcessingTime, double maxProcessingTime)
        {
            var terminals = new List<Terminal>();
            terminals.Clear();

            for (int i = 0; i < count; i++)
            {
                var terminal = new Terminal(i, maxQuantityCargo, maxPassableWeight, minProcessingTime, maxProcessingTime);
                terminals.Add(terminal);
            }
            return terminals;
        }
    }
}
