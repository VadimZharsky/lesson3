using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceCounter();
            Console.ReadKey();
        }

        private static void InstanceCounter()
        {
            GC.Collect(0);
            Console.WriteLine((double)GC.GetTotalMemory(true)/1024);
        }
    }
}
