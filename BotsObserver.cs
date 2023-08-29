using WeatherSystem.Models;
using WeatherSystem.Services;

namespace WeatherSystem
{
    public static class BotsObserver
    {
        public static List<WeatherBotDTO> Subscribers
        {
            get => BotsService.EnabledWeatherBots;
        }

        public static void NotifySubscribers(WeatherStateDTO weatherState)
        {
            Subscribers.ForEach(subscriber => subscriber.Update(weatherState));
        }
    }
}