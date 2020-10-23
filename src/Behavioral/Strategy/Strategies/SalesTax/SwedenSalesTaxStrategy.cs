using Strategy.Models;

namespace Strategy.Strategies.SalesTax
{
    public class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            decimal totalTax = 0m;

            foreach (var item in order.OrderItems)
            {
                switch (item.Key.ItemType)
                {
                    case ItemType.Food:
                        totalTax += (item.Key.Price * 0.06m) * item.Value;
                        break;

                    case ItemType.Literature:
                        totalTax += (item.Key.Price * 0.08m) * item.Value;
                        break;

                    case ItemType.Service:
                    case ItemType.Hardware:
                        totalTax += (item.Key.Price * 0.25m) * item.Value;
                        break;
                }
            }

            return totalTax;
        }

        // public decimal GetTax(Order order)
        // {
        //     var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
        //     var origin = order.ShippingDetails.OriginCountry.ToLowerInvariant();
        //     if (destination == origin)
        //     {
        //         return order.TotalPrice * 0.25m;
        //     }

        //     return 0;
        // }
    }
}