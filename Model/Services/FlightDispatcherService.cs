using System;
using System.Collections.Generic;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class FlightDispatcherService
    {
        private readonly FlightService _flightService;
        private readonly Random _rnd = new Random();

        public FlightDispatcherService(FlightService flightService)
        {
            _flightService = flightService;
        }

        public List<Flight> LaunchFlights(List<Runway> runways, int flightCount, double minDistance, double maxDistance)
        {
            var flights = new List<Flight>();
            int flightNumber = 1;

            var loadedAirplanes = new List<(Airplane airplane, Runway runway)>();
            foreach (var runway in runways)
            {
                while (runway.Airplanes.Count > 0)
                {
                    var airplane = runway.ReleaseAirplane();

                    if (airplane != null && airplane._cargoQuantity > 0 && airplane._currentLoad > 0)
                        loadedAirplanes.Add((airplane, runway));
                }
            }

            if (loadedAirplanes.Count == 0)
                return flights;

            var distances = new List<double>();
            for (int i = 0; i < flightCount; i++)
            {
                double distance = minDistance + _rnd.NextDouble() * (maxDistance - minDistance);
                distances.Add(distance);
            }

            for (int i = 0; i < loadedAirplanes.Count; i++)
            {
                var (airplane, runway) = loadedAirplanes[i];
                double distance = distances[i % distances.Count];

                var flight = _flightService.CreateFlight(flightNumber++, distance, airplane, runway);
                flights.Add(flight);
            }

            return flights;
        }


    }
}
