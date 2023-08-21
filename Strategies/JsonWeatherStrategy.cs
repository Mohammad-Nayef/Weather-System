using WeatherSystem.Models;
using System.Text.Json;

namespace WeatherSystem.Strategies
{
    public class JsonWeatherStrategy : IInputStrategy
    {
        public WeatherDTO? GetWeatherDTO(string input) => JsonSerializer.Deserialize<WeatherDTO?>(input);
    }
}