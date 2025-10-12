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

            for (int i = 0; i < flightCount; i++)
            {
                var runway = runways[i % runways.Count];
                var airplane = runway.ReleaseAirplane();

                // Проверяем, есть ли самолёт и есть ли у него груз
                if (airplane == null || airplane._cargoQuantity <= 0 || airplane._currentLoad <= 0)
                {
                    // Самолёт пустой — не создаём рейс, просто пропускаем
                    continue;
                }

                // Рассчитываем дистанцию полёта
                double distance = minDistance + _rnd.NextDouble() * (maxDistance - minDistance);

                // Создаём рейс
                var flight = _flightService.CreateFlight(flightNumber++, distance, airplane, runway);
                flights.Add(flight);
            }

            return flights;
        }

    }
}
