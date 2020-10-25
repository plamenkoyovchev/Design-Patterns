using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    /// An abstract 'Creator' class
    /// </summary>
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
