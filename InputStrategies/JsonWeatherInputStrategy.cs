using System.Text.Json;
using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class JsonWeatherInputStrategy : IWeatherInputStrategy
    {
        public WeatherStateDTO? GetWeatherDTO(string input) => JsonSerializer.Deserialize<WeatherStateDTO?>(input);
    }
}