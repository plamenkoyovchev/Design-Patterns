using System.Net.Http;
using Strategy.Models;
using System.Text.Json;
using System;

namespace Strategy.Strategies.Invoice
{
    public class PrintOnDemandInvoiceStrategy : IInvoiceStrategy
    {
        public void Generate(Order order)
        {
            using (var httpClient = new HttpClient())
            {
                var content = JsonSerializer.Serialize(order);

                httpClient.BaseAddress = new Uri("https://google.com");

                httpClient.PostAsync("/PrintOnDemand", new StringContent(content));
            }
        }
    }
}