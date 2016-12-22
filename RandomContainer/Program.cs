using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<int> container = new Container<int>();
            container.Push(10);
            container.Push(20);
            container.Push(30);

            // Generate 4 random items
            foreach (var item in container.Generate(4))
                Console.WriteLine(item);
        }
    }
}
