using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class DocumentFactory
    {
        public DocumentFactory()
        {
            this.CreatePages();
        }

        public List<Page> Pages { get; private set; } = new List<Page>();

        // Factory Method
        public abstract void CreatePages();
    }
}
