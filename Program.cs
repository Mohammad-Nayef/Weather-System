using WeatherSystem;
using WeatherSystem.Repositories;
using System.Text.Json;

try
{
    var x = ConfigRepository.Instance.BotsConfig;
    Console.WriteLine(x[0].Name);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}