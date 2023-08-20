using WeatherSystem.Models;

namespace WeatherSystem
{
    public  class Context
    {
        private IInputStrategy _strategy;

        public Context(IInputStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IInputStrategy strategy)
        {
            _strategy = strategy;
        }

        public WeatherDTO WeatherDeserialize(string input) => _strategy.GetWeatherDTO(input);        
    }
}