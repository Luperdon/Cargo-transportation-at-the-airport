using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class FlightService
    {
        private readonly Random _rnd = new Random();

        public List<Flight> CreateFlights(List<Runway> runways, int flightCount, double minDistance, double maxDistance)
        {
            var flights = new List<Flight>();
            int flightNumber = 1;

            for (int i = 0; i < flightCount; i++)
            {
                // Генерируем случайное расстояние полёта
                double distance = minDistance + _rnd.NextDouble() * (maxDistance - minDistance);

                // Берём следующую полосу циклически
                var runway = runways[i % runways.Count];

                // Извлекаем самолёт с полосы (удаляем из очереди)
                var airplane = runway.ReleaseAirplane();

                if (airplane != null)
                {
                    // Создаём полёт и считаем время полёта
                    var flight = new Flight(flightNumber++, distance, airplane, runway);
                    flights.Add(flight);
                }
            }

            return flights;
        }
    }


}
