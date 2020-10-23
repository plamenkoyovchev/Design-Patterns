using Strategy.Models;

namespace Strategy.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        decimal GetTax(Order order);
    }
}