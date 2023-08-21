using WeatherSystem.Models;
using WeatherSystem.Repositories;

namespace WeatherSystem.Services
{
    public static class BotsService
    {
        private static Dictionary<string, WeatherBotDTO> _weatherBots = ConfigRepository.Instance.BotsConfig;

        public static List<WeatherBotDTO> EnabledWeatherBots
        {
            get => MakeBotsList(_weatherBots)
                    .Where(bot => bot.Enabled == true)
                    .ToList();
        }

        private static List<WeatherBotDTO> MakeBotsList(Dictionary<string, WeatherBotDTO> bots)
        {
            var botsList = new List<WeatherBotDTO>();

            foreach (var bot in bots)
            {
                bot.Value.Name = bot.Key;
                botsList.Add(bot.Value);
            }

            return botsList;
        }
    }
}