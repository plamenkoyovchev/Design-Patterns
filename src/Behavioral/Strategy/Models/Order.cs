using System;
using System.Collections.Generic;
using Strategy.Strategies.Invoice;
using Strategy.Strategies.SalesTax;
using Strategy.Strategies.Shipping;

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

        public IInvoiceStrategy InvoiceStrategy { get; set; }

        public IShippingProvider ShippingProvider { get; set; }

        public decimal GetTax(ISalesTaxStrategy salesTaxStrategy = default)
        {
            var strategy = salesTaxStrategy ?? this.SalesTaxStrategy;
            if (strategy == null)
            {
                throw new NullReferenceException($"{nameof(SalesTaxStrategy)} is not provided");
            }

            return strategy.GetTax(this);
        }

        public void GetInvoice(IInvoiceStrategy invoiceStrategy = default)
        {
            var strategy = invoiceStrategy ?? this.InvoiceStrategy;
            if (strategy == null)
            {
                throw new NullReferenceException($"{nameof(InvoiceStrategy)} is not provided");
            }

            strategy.Generate(this);
        }
    }
}