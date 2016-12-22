using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomContainer
{
    public interface IRandomContainer<T>
    {
        // Add a single item to the container
        void Push(T item);

        // Return n random items from the container
        // without deleting them
        IEnumerable<T> Generate(int n);
    }
}
