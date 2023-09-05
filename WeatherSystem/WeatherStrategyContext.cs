using WeatherSystem.Models;

namespace WeatherSystem
{
    public class WeatherStrategyContext
    {
        private IWeatherInputStrategy _weatherInputStrategy;

        public WeatherStrategyContext() { }

        public WeatherStrategyContext(IWeatherInputStrategy strategy)
        {
            _weatherInputStrategy = strategy;
        }

        public void SetStrategy(IWeatherInputStrategy strategy)
        {
            _weatherInputStrategy = strategy;
        }

        public WeatherStateDTO WeatherDeserialize(string input) => _weatherInputStrategy.GetWeatherDTO(input);
    }
}