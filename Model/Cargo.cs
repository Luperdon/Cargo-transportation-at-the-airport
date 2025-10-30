namespace CargoTransportationAtTheAirportF.Model
{
    public class Cargo
    {
        public int _cargoNumber { get; set; }
        public double _cargoWeight { get; set; }
        public bool IsBroken { get; set; } = false;
        public double BreakProbability { get; set; } = 0.0;

        public Cargo(int cargoNumber, double cargoWeight, double breakProbability = 0.0)
        {
            _cargoNumber = cargoNumber;
            _cargoWeight = cargoWeight;
            BreakProbability = breakProbability;
        }
    }
}
