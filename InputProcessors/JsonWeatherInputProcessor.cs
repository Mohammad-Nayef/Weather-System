using System.Text.Json;
using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class JsonWeatherInputProcessor : IWeatherInputStrategy
    {
        public WeatherStateDTO? GetWeatherDTO(string input) => JsonSerializer.Deserialize<WeatherStateDTO?>(input);
    }
}