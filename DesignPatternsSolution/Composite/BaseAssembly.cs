using System.Collections.Generic;

namespace Composite
{
    public abstract class BaseAssembly
    {
        protected string Name;
        protected int Quantity;

        public BaseAssembly(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public abstract void Add(BaseAssembly assembly);
        public abstract void Remove(BaseAssembly assembly);
        public abstract void WritePartsList(List<string> list);
    }
}
