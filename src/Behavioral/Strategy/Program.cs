﻿using System;
using Strategy.Models;
using Strategy.Strategies.SalesTax;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var order = new Order()
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                },
                SalesTaxStrategy = new SwedenSalesTaxStrategy()
            };

            order.OrderItems.Add(new Item("CSHARP", "C#", 100m, ItemType.Literature), 1);

            Console.WriteLine($"Tax: ${order.GetTax()}");
        }
    }
}
