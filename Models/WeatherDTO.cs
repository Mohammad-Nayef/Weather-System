namespace WeatherSystem.Models
{
    public class WeatherDTO
    {
        public string? Location { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        
        public WeatherDTO(string location, float temperature, float humidity)
        {
            Location = location;
            Temperature = temperature;
            Humidity = humidity;
        }

        public WeatherDTO() { }

        public override string ToString()
        {
            return $"Location: {Location}\n" +
                   $"Temperature: {Temperature}\n" +
                   $"Humidity: {Humidity}";
        }
    }
}