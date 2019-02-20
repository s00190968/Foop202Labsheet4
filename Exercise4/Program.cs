using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("slugBug", 100, 10);

            c1.AboutToBlow += new CarEngineHandler(OnCarEngineEvent);
            c1.Exploded += new CarEngineHandler(OnCarEngineEvent2);

            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();
        }
        static void OnCarEngineEvent(object sender, CarEventArgs e)
        {
            Console.WriteLine("Message from Car Object\n");
            Console.WriteLine(e.message);
            Console.WriteLine("****************");
        }

        static void OnCarEngineEvent2(object sender, CarEventArgs e)
        {
            Console.WriteLine(e.message.ToUpper());
        }
    }
}
