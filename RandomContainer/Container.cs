using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomContainer
{
    class Container<T> : IRandomContainer<T>
    {
        List<T> _items = new List<T>();
        Random r = new Random();
        
        public void Push(T item)
        {
            _items.Add(item);
        }

        public IEnumerable<T> Generate(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("Invalid value of n");
            for (int i = 0; i < n; i++)
            {
                int index = r.Next(_items.Count);
                yield return _items[index];
            }
        }
    }
}
