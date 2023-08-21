namespace WeatherSystem
{
    public class BotData
    {
        public bool? Enabled { get; set; } = new();
        public int? HumidityThreshold { get; set; } = null;
        public int? TemperatureThreshold { get; set; } = null;
        public string? Message { get; set; } = null;
    }
}
