using Strategy.Models;

namespace Strategy.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        void Generate(Order order);
    }
}