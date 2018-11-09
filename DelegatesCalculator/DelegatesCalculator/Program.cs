using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCalculator
{
    class Program
    {
        public delegate double del(double x, double y);
        static void Main(string[] args)
        {
            del _del = null;
            Console.Write("input x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("input operator: ");
            char act = Convert.ToChar(Console.ReadLine());
            Console.Write("input y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            ToCalculate(_del, x, y, act);
            Console.ReadKey();
        }

        private static void ToCalculate(del _del, double x, double y, char act)
        {
            double result = 0;
            switch (act)
            {
                case '+':
                    _del += Add;
                    result = _del(x, y);
                    break;
                case '-':
                    _del += Substraction;
                    result = _del(x, y);
                    break;
                case '*':
                    _del += Multiplication;
                    result = _del(x, y);
                    break;
                case '/':
                    _del += Division;
                    result = _del(x, y);
                    break;
            }
            Console.WriteLine("Result is {0}", result);
        }


        private static double Add(double x, double y)
        {
            return x + y;
        }
        private static double Substraction(double x, double y)
        {
            return x - y;
        }
        private static double Multiplication(double x, double y)
        {
            return x * y;
        }
        private static double Division(double x, double y)
        {
            return x / y;
        }
    }
}
