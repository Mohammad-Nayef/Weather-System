using WeatherSystem.Models;

namespace WeatherSystem
{
    public interface IInputStrategy
    {
        WeatherDTO GetWeather(string input);
    }
}