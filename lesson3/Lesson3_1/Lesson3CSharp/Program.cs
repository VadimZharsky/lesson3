using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius of a circle");
            double rad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of this circle is equal to: "+circleArea(rad));
            Console.ReadKey();
        }
        static double circleArea(double r)
        {
            double pi = Math.PI;
            double res = pi * (Math.Pow(r, 2));
            return res;
        }
    }
}
