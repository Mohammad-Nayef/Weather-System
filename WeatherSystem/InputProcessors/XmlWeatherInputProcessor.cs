using System.Xml.Serialization;
using WeatherSystem.Models;

namespace WeatherSystem.Strategies
{
    public class XmlWeatherInputProcessor : IWeatherInput
    {
        public WeatherStateDTO? GetWeatherDTO(string input)
        {
            var weather = new WeatherStateDTO();
            var serializer = new XmlSerializer(weather.GetType());

            using (var reader = new StringReader(input))
            {
                weather = (WeatherStateDTO?)serializer.Deserialize(reader);
            }

            return weather;
        }
    }
}