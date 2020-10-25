using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main()
        {
            var documents = new DocumentFactory[]
            {
                new ResumeFactory(),
                new ReportFactory()
            };

            foreach (DocumentFactory document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}
