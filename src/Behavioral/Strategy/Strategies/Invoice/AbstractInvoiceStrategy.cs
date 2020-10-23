using Strategy.Models;
using Strategy.Strategies.Invoice;

namespace Strategy.Strategies.Invoice
{
    public abstract class AbstractInvoiceStrategy : IInvoiceStrategy
    {
        public abstract void Generate(Order order);

        protected string GenerateTextInvoice(Order order)
        {
            return "Text Invoice";
        }
    }
}