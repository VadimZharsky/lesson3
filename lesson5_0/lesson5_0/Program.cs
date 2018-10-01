using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            int count = 1;
            int result = num;
            while (count < 8)
            {
                result = result * num;
                count++;
                Console.WriteLine(result);
            }
            akinator();
            Console.ReadKey();
        }
        static void akinator()
        {
            Console.WriteLine("Akinator from 0 to 100");
            bool ifDone = false;
            int part = 50;
            int temp = 100;
            int del = 2;
            while (ifDone == false)
            {
                
                Console.WriteLine($"your number is greater than {temp - temp/del}?\n1.yes\n2.no");
                byte choise = Convert.ToByte(Console.ReadLine());
                if (choise == 1)
                {
                    part = temp / (del / 2);
                    Console.WriteLine($"your number is between {part} and {temp - temp / del}");
                    del *= 2;
                }
                else
                {
                    Console.WriteLine($"your number is greater than {part}?\n1.yes\n2.no");
                    // part = 
                }
            }
        }
    }
}
