using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericGuessType
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2015,07,18);
            GuessType(date);
            GuessType("Hello sharp");
            GuessType(34.79);
            GuessType(58);
            GuessType('s');
            Console.ReadKey();
            
        }
        public static void GuessType<T>(T obj)
        {
            Console.WriteLine(obj.GetType());
            switch (obj)
            {
                case string x:
                    {
                        Console.WriteLine("this is string \"{0}\"", x);
                        break;
                    }
                case int x:
                    {
                        Console.WriteLine("this is int {0}", x);
                        break;
                    }
                case DateTime x:
                    {
                        Console.WriteLine("This is a date {0}", x);
                        break;
                    }
                case char x:
                    {
                        Console.WriteLine("This is a character '{0}'", x);
                        break;
                    }
                case double x:
                    {
                        Console.WriteLine("This is a double {0}", x);
                        break;
                    }


            }
        }
    }
}
