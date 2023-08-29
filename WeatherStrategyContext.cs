using WeatherSystem.Models;

namespace WeatherSystem
{
    public class WeatherStrategyContext
    {
        private IWeatherInputStrategy _strategy;

        public WeatherStrategyContext() { }

        public WeatherStrategyContext(IWeatherInputStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IWeatherInputStrategy strategy)
        {
            _strategy = strategy;
        }

        public WeatherStateDTO WeatherDeserialize(string input) => _strategy.GetWeatherDTO(input);
    }
}