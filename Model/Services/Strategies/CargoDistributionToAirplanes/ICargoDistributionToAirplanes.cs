using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public interface ICargoDistributionToAirplanes
    {
        Airplane ChooseAirplane(Cargo cargo, List<Airplane> airplanes);
    }
}
