using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                ThreadPool.QueueUserWorkItem((object state) =>
                {
                    lock (rnd)
                    {
                        File.AppendAllText($@"temp{i}.txt", $"this is {i}th string\n");
                        Thread.Sleep(rnd.Next(0, 200));
                        Console.WriteLine(i);
                    }
                    
                });
            }

            Console.ReadKey();
            
        }
    }
}
