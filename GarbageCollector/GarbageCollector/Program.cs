using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    using System;

    class Program
    {
        static void Main(string []args)
        {
            ObjectCreator();
            Console.WriteLine((double)GC.GetTotalMemory(true)/1024);
            
            
            Console.ReadKey();
        }
        static void ObjectCreator()
        {
            List<SimpleClass> list = new List<SimpleClass>();
            for (int i = 0; i < 500000; i++)
            {
                SimpleClass simple = new SimpleClass(ShowMessage);
                
                
                //list.Add(simple);
                //GC.KeepAlive(list);
                if (i % 50000 == 0)
                {
                    //Console.WriteLine(GC.GetGeneration(simple));
                    simple.GetNum();
                    simple.Dispose();
                    simple.GetNum();
                }
            }
        }
        public static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }

}
