using System.Xml.Serialization;
using WeatherSystem.Models;

namespace WeatherSystem
{
    public class XmlInputStrategy : IInputStrategy
    {
        public WeatherDTO? GetWeatherDTO(string input)
        {
            var weather = new WeatherDTO();
            var serializer = new XmlSerializer(weather.GetType());

            using (var reader = new StringReader(input))
            {
                weather = (WeatherDTO?)serializer.Deserialize(reader);
            }

            return weather;
        }
    }
}