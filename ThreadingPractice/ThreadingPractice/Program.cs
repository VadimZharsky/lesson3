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
            for (int i = 0; i < 40; i++)
            {
                ThreadPool.QueueUserWorkItem((object state) =>
                {
                    
                    //lock (rnd)
                        {
                        
                        Thread.Sleep(rnd.Next(0, 2000));
                        Console.WriteLine($"for {Thread.CurrentThread.ManagedThreadId} number is {i}");
                        }
                        
                    
                });
                File.AppendAllText($@"temp{i}.txt", $"this is {i}th string\n");
            }

            Console.ReadKey();
            
        }
    }
}
