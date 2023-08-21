namespace WeatherSystem.Models
{
    public class WeatherBotDTO
    {
        public string? Name { get; set; }
        public bool? Enabled { get; set; }
        public string? Message { get; set; }
        public int? HumidityThreshold { get; set; }
        public int? TemperatureAboveThreshold { get; set; }
        public int? TemperatureUnderThreshold { get; set; }
        public bool? IsThresholdTriggered { get; private set; } = false;

        public void Update(WeatherStateDTO weatherState)
        {
            IsThresholdTriggered = HumidityThresholdTriggered(weatherState) ||
                TemperatureAboveThresholdTriggered(weatherState) ||
                TemperatureUnderThresholdTriggered(weatherState);
        }

        private bool HumidityThresholdTriggered(WeatherStateDTO weatherState)
        {
            if (HumidityThreshold != null)
                return HumidityThreshold <= weatherState.Humidity;

            return false;
        }

        private bool TemperatureAboveThresholdTriggered(WeatherStateDTO weatherState)
        {
            if (TemperatureAboveThreshold != null)
                return TemperatureAboveThreshold < weatherState.Temperature;

            return false;
        }

        private bool TemperatureUnderThresholdTriggered(WeatherStateDTO weatherState)
        {
            if (TemperatureUnderThreshold != null)
                return TemperatureUnderThreshold > weatherState.Temperature;

            return false;
        }
    }
}