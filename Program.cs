using WeatherSystem;
using WeatherSystem.Models;
using WeatherSystem.Services;
using WeatherSystem.Strategies;

while (true)
{
    Console.WriteLine("Weather monitoring and reporting service\n");
    Console.WriteLine("Enter weather state using one of the following formats:");
    Console.WriteLine("1. JSON Format");
    Console.WriteLine("2. XML Format");
    Console.Write("\nChoose an option: ");
    var inputOption = Console.ReadLine();

    if (!int.TryParse(inputOption, out var option) || option != 1 && option != 2)
    {
        Console.WriteLine("Invalid option");
        goto repeat;
    }

    var inputStrategy = new WeatherStrategyContext();

    if (option == 1)
        inputStrategy.SetStrategy(new JsonWeatherInputStrategy());
    else
        inputStrategy.SetStrategy(new XmlWeatherInputStrategy());

    Console.WriteLine("Enter the weather state object:");
    var weatherStateInput = Console.ReadLine();
    WeatherStateDTO weatherState = new();

    try
    {
        weatherState = inputStrategy.WeatherDeserialize(weatherStateInput);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Invalid input:\n{e.Message}");
        goto repeat;
    }

    BotsObserver.NotifySubscribers(weatherState);

    BotsService.GetTriggeredWeatherBots()
        .ForEach(bot => {
                Console.WriteLine($"{bot.Name} activated!");
                Console.WriteLine($"{bot.Name}: \"{bot.Message}\"\n");
            }
        );

repeat:
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
    Console.Clear();
}