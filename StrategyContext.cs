using WeatherSystem.Models;

namespace WeatherSystem
{
    public  class StrategyContext
    {
        private IInputStrategy _strategy;

        public StrategyContext(IInputStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IInputStrategy strategy)
        {
            _strategy = strategy;
        }

        public WeatherStateDTO WeatherDeserialize(string input) => _strategy.GetWeatherDTO(input);        
    }
}