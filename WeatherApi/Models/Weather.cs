﻿namespace WeatherApi.Models
{
    public class Weather
    {
        public string City { get; set; }
        public string Description { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
    }
}
