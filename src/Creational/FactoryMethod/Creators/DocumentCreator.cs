using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class DocumentCreator
    {
        public DocumentCreator()
        {
            this.CreatePages();
        }

        public List<Page> Pages { get; private set; } = new List<Page>();

        // Factory Method
        public abstract void CreatePages();
    }
}
