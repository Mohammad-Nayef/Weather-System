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

        /// <summary>
        /// Activates specific bots based on the current weather state.
        /// </summary>
        public static void NotifySubscribers(WeatherStateDTO weatherState)
        {
            Subscribers.ForEach(subscriber => subscriber.Update(weatherState));
        }
    }
}