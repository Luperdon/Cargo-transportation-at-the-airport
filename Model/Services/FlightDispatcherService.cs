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

            // 1️⃣ Собираем всех загруженных самолётов со всех полос
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
                return flights; // Нет самолётов — выходим

            // 2️⃣ Создаём список дистанций (точек)
            var distances = new List<double>();
            for (int i = 0; i < flightCount; i++)
            {
                double distance = minDistance + _rnd.NextDouble() * (maxDistance - minDistance);
                distances.Add(distance);
            }

            // 3️⃣ Назначаем каждому самолёту одну из точек (циклически)
            for (int i = 0; i < loadedAirplanes.Count; i++)
            {
                var (airplane, runway) = loadedAirplanes[i];
                double distance = distances[i % distances.Count]; // равномерное распределение

                var flight = _flightService.CreateFlight(flightNumber++, distance, airplane, runway);
                flights.Add(flight);
            }

            return flights;
        }


    }
}
