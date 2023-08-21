namespace WeatherSystem.Models
{
    public class WeatherStateDTO
    {
        public string? Location { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        
        public WeatherStateDTO(string location, float temperature, float humidity)
        {
            Location = location;
            Temperature = temperature;
            Humidity = humidity;
        }

        public WeatherStateDTO() { }

        public override string ToString()
        {
            return $"Location: {Location}\n" +
                   $"Temperature: {Temperature}\n" +
                   $"Humidity: {Humidity}";
        }
    }
}