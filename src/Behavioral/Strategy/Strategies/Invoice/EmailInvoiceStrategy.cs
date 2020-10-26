using System;
using Strategy.Models;

namespace Strategy.Strategies.Invoice
{
    public class EmailInvoiceStrategy : AbstractInvoiceStrategy
    {
        public override void Generate(Order order)
        {
            var body = base.GenerateTextInvoice(order);

            // TODO: code send email (SmtpClient maybe with SendGrid)

            Console.WriteLine($"Email sent ... \n Body: {body}");
        }
    }
}