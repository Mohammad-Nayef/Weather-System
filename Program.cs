using WeatherSystem;
using WeatherSystem.Repositories;
using System.Text.Json;

try
{
    var x = ConfigRepository.Instance.BotsConfig;
    var rain = x["SunBot"];
    Console.WriteLine(rain.TemperatureThreshold ?? 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}