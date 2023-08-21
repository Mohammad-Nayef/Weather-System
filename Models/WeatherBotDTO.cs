namespace WeatherSystem.Models
{
    public class WeatherBotDTO
    {
        public string? Name { get; set; }
        public bool? Enabled { get; set; }
        public string? Message { get; set; }
        public int? HumidityThreshold { get; set; }
        public int? TemperatureThreshold { get; set; }
        public bool? IsThresholdTriggered { get; private set; } = false;

        public void Update(WeatherStateDTO weatherState)
        {
            if (HumidityThreshold != null)
                IsThresholdTriggered = HumidityThreshold <= weatherState.Humidity;

            if (TemperatureThreshold != null)
                IsThresholdTriggered = TemperatureThreshold <= weatherState.Temperature;
        }
    }
}