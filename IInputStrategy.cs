using WeatherSystem.Models;

namespace WeatherSystem
{
    public interface IInputStrategy
    {
        public WeatherDTO GetWeather(string input);
    }
}