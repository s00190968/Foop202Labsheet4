using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{

    public delegate void BinaryOp(int x, int y);
    public class SimpleMaths
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"The result of { x }+{ y } is: {x + y}.");
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine($"The result of { x }-{ y } is: {x - y}.");
        }
    }
}
