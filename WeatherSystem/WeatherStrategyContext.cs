using WeatherSystem.Models;

namespace WeatherSystem
{
    public class WeatherStrategyContext
    {
        private IWeatherInput _weatherInputStrategy;

        public WeatherStrategyContext() { }

        public WeatherStrategyContext(IWeatherInput strategy)
        {
            _weatherInputStrategy = strategy;
        }

        public void SetStrategy(IWeatherInput strategy)
        {
            _weatherInputStrategy = strategy;
        }

        public WeatherStateDTO WeatherDeserialize(string input) => _weatherInputStrategy.GetWeatherDTO(input);
    }
}