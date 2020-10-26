using System;
using System.Net.Http;
using Strategy.Models;

namespace Strategy.Strategies.Shipping
{
    public class EcontShippingProvider : IShippingProvider
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                // TODO Econt API integration
            }

            Console.WriteLine("Shipping with Econt");
        }
    }
}