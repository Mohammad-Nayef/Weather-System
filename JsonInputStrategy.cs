using WeatherSystem.Models;
using System.Text.Json;

namespace WeatherSystem
{
    public class JsonInputStrategy : IInputStrategy
    {
        public WeatherDTO GetWeather(string input) => JsonSerializer.Deserialize<WeatherDTO>(input);
    }
}