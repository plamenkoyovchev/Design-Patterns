using System;
using System.Net.Http;
using Strategy.Models;

namespace Strategy.Strategies.Shipping
{
    public class SpeedyShippingProvider : IShippingProvider
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                // TODO Speedy API integration
            }

            Console.WriteLine("Shipping with Speedy");
        }
    }
}