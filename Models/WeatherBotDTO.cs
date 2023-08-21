﻿namespace WeatherSystem.Models
{
    public class WeatherBotDTO
    {
        public string? Name { get; set; }
        public bool? Enabled { get; set; }
        public string? Message { get; set; }
        public int? HumidityThreshold { get; set; }
        public int? TemperatureThreshold { get; set; }

        //public void Update()
    }
}