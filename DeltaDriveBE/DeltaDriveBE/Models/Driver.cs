﻿namespace DeltaDriveBE.Models
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string? Brand { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? StartPrice { get; set; }
        public double? PricePerKm { get; set; }
        public int? Rating { get; set; }
    }
}
