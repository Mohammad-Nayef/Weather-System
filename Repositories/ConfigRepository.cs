using System.Text.Json;

namespace WeatherSystem.Repositories
{
    public class ConfigRepository
    {
        private static ConfigRepository? _instance = null;
        private const string _configFilePath = "Configs\\BotsConfig.json";
        private Dictionary<string, BotData> _botsConfig;

        public Dictionary<string, BotData> BotsConfig
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

        private Dictionary<string, BotData> GetBotsConfig()
        {
            var relativePath = Path.Combine(Directory.GetCurrentDirectory(), _configFilePath);
            var rawData = File.ReadAllText(relativePath);

            return JsonSerializer.Deserialize<Dictionary<string, BotData>>(rawData);
        }
    }
}