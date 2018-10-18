using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_workWithStrings_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a phrase");
            string line = Console.ReadLine();
            Console.WriteLine(line);
            string result = line.Worker();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
