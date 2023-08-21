using System.Text.Json;
using WeatherSystem.Models;

namespace WeatherSystem.Repositories
{
    public class ConfigRepository
    {
        private static ConfigRepository? _instance = null;
        private const string _configFilePath = "Configs\\BotsConfig.json";
        private Dictionary<string, WeatherBotDTO> _botsConfig;

        public Dictionary<string, WeatherBotDTO> BotsConfig
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

        private Dictionary<string, WeatherBotDTO> GetBotsConfig()
        {
            var relativePath = Path.Combine(Directory.GetCurrentDirectory(), _configFilePath);
            var rawData = File.ReadAllText(relativePath);

            return JsonSerializer.Deserialize<Dictionary<string, WeatherBotDTO>>(rawData);
        }
    }
}