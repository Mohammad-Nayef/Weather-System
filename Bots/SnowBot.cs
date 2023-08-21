using System.Text.Json.Serialization;

namespace WeatherSystem.Bots
{
    public class SnowBot : IWeatherBot
    {
        public bool? Enabled { get; set; } = null;
        public string? Message { get; set; } = null;
        public int? HumidityThreshold { get; set; } = null;
        public int? TemperatureThreshold { get; set; } = null;

        public override void Update()
        {

        }
    }
}