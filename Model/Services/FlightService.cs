namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class FlightService
    {
        public Flight CreateFlight(int flightNumber, double distance, Airplane airplane, Runway runway)
        {
            return new Flight(flightNumber, distance, airplane, runway);
        }
    }
}
