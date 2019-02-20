using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryOp d1 = new BinaryOp(SimpleMaths.Add);
            BinaryOp d2 = new BinaryOp(SimpleMaths.Subtract);

            d1 += d2;
            DoWork(d1);

            Console.ReadLine();
            
        }
        static void DoWork(BinaryOp d)
        {
            d(20, 10);
        }
    }
}
