﻿namespace WeatherSystem.Bots
{
    public abstract class WeatherBot
    {
        public bool Enabled { get; set; }
        public string? Message { get; set; }
        public int HumidityThreshold { get; set; }
        public int TemperatureThreshold { get; set; }

        public abstract void Update();
    }
}