using WeatherSystem.Models;
using System.Text.Json;

namespace WeatherSystem
{
    public class JsonInputStrategy : IInputStrategy
    {
        public WeatherDTO? GetWeatherDTO(string input) => JsonSerializer.Deserialize<WeatherDTO>(input);
    }
}