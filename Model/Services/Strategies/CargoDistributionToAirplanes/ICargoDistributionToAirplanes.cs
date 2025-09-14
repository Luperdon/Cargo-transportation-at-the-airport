using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies.CargoDistributionToAirplanes
{
    public interface ICargoDistributionToAirplanes
    {
        bool DistributeCargoToAirplanes(Cargo cargo, List<Airplane> airplanes);
    }
}
