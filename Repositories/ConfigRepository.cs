namespace WeatherSystem.Repositories
{
    public class ConfigRepository
    {
        private static ConfigRepository? _instance = null;
        private const string _configFilePath = "Configs\\BotsConfig.json";

        private ConfigRepository() { }


    }
}