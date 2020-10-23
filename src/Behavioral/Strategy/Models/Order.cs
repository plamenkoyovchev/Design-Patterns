using System;
using System.Collections.Generic;
using Strategy.Strategies.SalesTax;

namespace Strategy.Models
{
    public class Order
    {
        public Order()
        {
            this.ShippingDetails = new ShippingDetails();
        }

        public Dictionary<Item, int> OrderItems { get; } = new Dictionary<Item, int>();

        public ShippingDetails ShippingDetails { get; set; }

        public decimal TotalPrice { get; set; }

        public ISalesTaxStrategy SalesTaxStrategy { get; set; }

        public decimal GetTax(ISalesTaxStrategy salesTaxStrategy = default)
        {
            var strategy = salesTaxStrategy ?? this.SalesTaxStrategy;
            if (strategy == null)
            {
                throw new NullReferenceException($"{nameof(SalesTaxStrategy)} is not provided");
            }

            return strategy.GetTax(this);
        }
    }
}