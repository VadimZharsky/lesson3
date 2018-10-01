using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Convert.ToString(Console.ReadLine());
            string symbol = Convert.ToString(Console.ReadLine());
            string second = Convert.ToString(Console.ReadLine());

            try
            {
                double x = Convert.ToDouble(first);
                double y = Convert.ToDouble(second);
                char symb = Convert.ToChar(symbol);
                Console.WriteLine("How do you want to make a calculation? :\n1.Through if/else\n2.Through switch/case\n3.Through new switch/case");
                string choice = Convert.ToString(Console.ReadLine());
                byte selected = Convert.ToByte(choice);
                if (selected == 1) { Calculated(x, y, symb); }
                if (selected == 2) { Calc(x, y, symb); }
                if (selected == 3)
                {
                    Expression exp = new Expression(x, y, symb);
                    NewCalc(exp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("incorrect input data");
            }

            Console.ReadKey();
        }

        private static void NewCalc(Expression exp)
        {
            string result = "";
            switch (exp)
            {
                case Expression expression when(exp.symb=='+'):
                    result = $"{exp.x} + {exp.y} = {exp.x + exp.y}";
                    break;
                case Expression expression when (exp.symb == '-'):
                    result = $"{exp.x} - {exp.y} = {exp.x - exp.y}";
                    break;
                case Expression expression when (exp.symb == '*'):
                    result = $"{exp.x} * {exp.y} = {exp.x * exp.y}";
                    break;
                case Expression expression when (exp.symb == '/'):
                    result = $"{exp.x} / {exp.y} = {exp.x / exp.y}";
                    break;
                default:
                    result ="incorrect input data";
                    break;

            }
            Console.WriteLine(result);
        }

        private static void Calculated(double x, double y, char symbol)
        {
            string result = "";
            if (symbol == '+') { result = $"{x} + {y} = {x + y}"; }
            else if (symbol == '-') { result = $"{x} - {y} = {x - y}"; }
            else if (symbol == '*') { result = $"{x} * {y} = {x * y}"; }
            else if (symbol == '/') { result = $"{x} / {y} = {x / y}"; }
            else { Console.WriteLine("incorrect input data"); }
            Console.WriteLine(result);
        }

        static void Calc(double x, double y, char symb)
        {
            string result = "";
            switch (symb)
            {
                case '+':
                    result = $"{x} + {y} = {x + y}";
                    break;
                case '-':
                    result = $"{x} - {y} = {x - y}";
                    break;
                case '*':
                    result = $"{x} * {y} = {x * y}";
                    break;
                case '/':
                    result = $"{x} / {y} = {x / y}";
                    break;
                default:
                    result = "incorrect input data";
                    break;
            }
            Console.WriteLine(result);
        }
    }
    public class Expression
    {
        public double x, y;
        public char symb;

        public Expression(double x, double y,char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }


    }
}
