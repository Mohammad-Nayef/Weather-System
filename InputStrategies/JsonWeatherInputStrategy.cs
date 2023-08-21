using WeatherSystem.Models;
using System.Text.Json;

namespace WeatherSystem.Strategies
{
    public class JsonWeatherInputStrategy : IWeatherInputStrategy
    {
        public WeatherStateDTO? GetWeatherDTO(string input) => JsonSerializer.Deserialize<WeatherStateDTO?>(input);
    }
}