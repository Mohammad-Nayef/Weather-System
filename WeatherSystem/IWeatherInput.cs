using WeatherSystem.Models;

namespace WeatherSystem
{
    public interface IWeatherInput
    {
        public WeatherStateDTO? GetWeatherDTO(string input);
    }
}