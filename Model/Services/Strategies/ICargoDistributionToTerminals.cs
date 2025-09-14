using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public interface ICargoDistributionToTerminals
    {
        bool DistributeCargoToTerminals(Cargo cargo, List<Terminal> terminals);
    }
}
