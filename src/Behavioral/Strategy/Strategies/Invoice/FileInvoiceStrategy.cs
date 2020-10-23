using System;
using System.IO;
using Strategy.Models;

namespace Strategy.Strategies.Invoice
{
    public class FileInvoiceStrategy : AbstractInvoiceStrategy
    {
        public override void Generate(Order order)
        {
            var text = base.GenerateTextInvoice(order);

            using (var stream = new StreamWriter($"Invoice_{DateTime.Now.Date}.txt"))
            {
                stream.Write(text);
                stream.Flush();
            }

            Console.WriteLine("Saved to file ... ");
        }
    }
}