using WeatherSystem.Models;
using WeatherSystem.Repositories;

namespace WeatherSystem.Services
{
    public static class BotsService
    {
        private static Dictionary<string, WeatherBotDTO> _weatherBots = BotsConfigRepository.Instance.BotsConfig;

        public static List<WeatherBotDTO> EnabledWeatherBots
        {
            get => GetBotsList(_weatherBots)
                    .Where(bot => bot.Enabled == true)
                    .ToList();
        }

        private static List<WeatherBotDTO> GetBotsList(Dictionary<string, WeatherBotDTO> bots)
        {
            var botsList = new List<WeatherBotDTO>();

            foreach (var bot in bots)
            {
                bot.Value.Name = bot.Key;
                botsList.Add(bot.Value);
            }

            return botsList;
        }

        public static List<WeatherBotDTO> GetTriggeredWeatherBots()
        {
            return EnabledWeatherBots.
                    Where(bot => bot.IsThresholdTriggered == true)
                    .ToList();
        }
    }
}