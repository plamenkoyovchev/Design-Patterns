using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main()
        {
            var documents = new DocumentCreator[]
            {
                new ResumeCreator(),
                new ReportCreator()
            };

            foreach (DocumentCreator document in documents)
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
