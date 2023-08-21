using WeatherSystem.Models;
using System.Text.Json;

namespace WeatherSystem.Strategies
{
    public class JsonInputWeatherStrategy : IInputStrategy
    {
        public WeatherStateDTO? GetWeatherDTO(string input) => JsonSerializer.Deserialize<WeatherStateDTO?>(input);
    }
}