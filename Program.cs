using WeatherSystem;
using WeatherSystem.Repositories;
using WeatherSystem.Bots;
using System.Text.Json;

bool y = new();
Console.WriteLine(y);
try
{
    var x = ConfigRepository.Instance.BotsConfig;
    var rain = x["SunBot"];
    Console.WriteLine(rain.HumidityThreshold ?? 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}