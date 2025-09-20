using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services.Strategies.CargoDistributionToAirplanes
{
    public class NormalDistributionToAirplanesStrategy : ICargoDistributionToAirplanes
    {
        public Airplane ChooseAirplane(Cargo cargo, List<Airplane> airplanes)
        {
            return airplanes
                .Where(a => a._currentLoad + cargo._cargoWeight <= a._loadCapacity)
                .OrderBy(a => a._cargoQuantity)
                .FirstOrDefault();
        }
    }
}
