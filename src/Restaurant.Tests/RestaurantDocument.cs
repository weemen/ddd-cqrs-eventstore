﻿using System.Collections.Generic;

namespace Restaurant.Tests
{
    public class RestaurantDocument
    {
        public int TableNumber { get; set; }
        public int TimeToCookMs { get; set; }
        public double Tax { get; set; }
        public List<Item> Items { get; set; }
        public List<string> Ingredients { get; set; }
        public double Total { get; set; }
        public double Paid { get; set; }

        public RestaurantDocument()
        {
            Items = new List<Item>();
        }
    }
}