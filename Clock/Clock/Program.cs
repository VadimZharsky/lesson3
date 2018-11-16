using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(Timer);
            thread.Start();

            while (true)
            {
                
                string s = Console.ReadLine();
                switch (s)
                {
                    case"w":
                        thread.Resume();
                        break;
                    case "s":
                        thread.Suspend();
                        break;
                }
                
            }
            
            Console.ReadKey();
        }
        public static void Timer()
        {
            while (true)
            {
                Console.Clear();
                DateTime time = DateTime.Now;
                Console.WriteLine(time);
                Thread.Sleep(1000);
            }
        }

    }
}
