using Strategy.Models;

namespace Strategy.Strategies.SalesTax
{
    public class UsSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": return order.TotalPrice * 0.1m;
                case "ny": return order.TotalPrice * 0.05m;
                case "bo": return order.TotalPrice * 0.04m;
                default: return 0;
            }
        }
    }
}