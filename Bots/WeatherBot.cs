namespace WeatherSystem.Bots
{
    public abstract class WeatherBot
    {
        public abstract bool Enabled { get; set; }
        public abstract string? Message { get; set; }

        public abstract void Update();
    }
}