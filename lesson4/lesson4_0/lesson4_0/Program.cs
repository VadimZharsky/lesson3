using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select  an excercise:\n1.\n2.");            
            byte selected = Convert.ToByte(Console.ReadLine());
            if (selected == 1) { ExFirst(); }
            else if (selected == 2) { ExSecond(); }
            else { Console.WriteLine("Incorrect input data."); }
            Console.ReadKey();
        }

        static void ExFirst()
        {
            for (int i = 10; i >= 0; i--)
            {
                if (i % 2 == 0) { Console.WriteLine(i + " is even number");}
                else { Console.WriteLine(i + " is odd number");  }
            }
        }

        static void ExSecond()
        {
            int aQuantity = 0;
            Console.WriteLine("Enter some word");
            string str = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    aQuantity++;
                }
            }
            Console.WriteLine("Quantity of a letter a in received word is: {0}.", aQuantity);
        }
    }
}
