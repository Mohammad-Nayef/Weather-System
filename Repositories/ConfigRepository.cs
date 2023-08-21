using System.Text.Json;
using WeatherSystem.Models;

namespace WeatherSystem.Repositories
{
    public class ConfigRepository
    {
        private static ConfigRepository? _instance = null;
        private const string _configFilePath = "Configs\\BotsConfig.json";
        private List<WeatherBotDTO> _botsConfig;

        public List<WeatherBotDTO> BotsConfig
        {
            get => _botsConfig;
        }

        public static ConfigRepository? Instance
        { 
            get => _instance ?? new();
        }

        private ConfigRepository() 
        {
            _botsConfig = GetBotsConfig();
        }

        private List<WeatherBotDTO> GetBotsConfig()
        {
            var relativePath = Path.Combine(Directory.GetCurrentDirectory(), _configFilePath);
            var rawData = File.ReadAllText(relativePath);
            var bots = JsonSerializer.Deserialize<Dictionary<string, WeatherBotDTO>>(rawData);

            return MakeBotsList(bots);
        }

        private List<WeatherBotDTO> MakeBotsList(Dictionary<string, WeatherBotDTO> bots)
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