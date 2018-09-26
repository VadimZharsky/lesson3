using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a credit amount");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter an interest rate");
            decimal percent = Convert.ToDecimal(Console.ReadLine());
            creditCalc(sum, percent);                
            Console.ReadKey();
        }
        static void creditCalc(decimal s, decimal per)
        {
            per = per / 100;
            const int year = 1;
            const int monthSum = 12;
            decimal pow = Convert.ToDecimal(Math.Pow(Convert.ToDouble(1+(per / monthSum)),(year*monthSum)));
            decimal res = (s * (per / monthSum)) / (1-(1/pow));
            res = Math.Round(res, 2);
            decimal amount = 0;
            Console.WriteLine("Payments by month");
            for (int i = 1; i <=12; i++)
            {
                Console.WriteLine(i + " Month: " + res + "  BYN");
                amount += res;
            }
            Console.WriteLine("Total amount of payments is: "+amount);
        }
    }
}
