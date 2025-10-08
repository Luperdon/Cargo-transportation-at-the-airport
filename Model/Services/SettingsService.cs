using Newtonsoft.Json;
using System.IO;

namespace CargoTransportationAtTheAirportF.Model.Services
{
    public class SettingsService
    {
        // Класс для хранения всех настроек
        public class AppSettings
        {
            public int CargoCount { get; set; }
            public double MinCargoWeight { get; set; }
            public double MaxCargoWeight { get; set; }

            public int AirplaneCount { get; set; }
            public double AirplaneSpeed { get; set; }
            public double AirplaneLoadCapacity { get; set; }
            public double MinLoadingTime { get; set; }
            public double MaxLoadingTime { get; set; }
            public string SelectedStrategyAirplanes { get; set; }

            public int TerminalCount { get; set; }
            public int TerminalMaxCapacity { get; set; }
            public double MinProcessingTime { get; set; }
            public double MaxProcessingTime { get; set; }
            public double MaxPassableWeight { get; set; }
            public string SelectedStrategyTerminals { get; set; }

            public int RunwayCount { get; set; }

            public int FlightCount { get; set; }
            public double MinDistance { get; set; }
            public double MaxDistance { get; set; }
        }

        // Сохранение настроек в JSON
        public AppSettings LoadSettings(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<AppSettings>(json);
        }

        public void SaveSettings(string filePath, AppSettings settings)
        {
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
