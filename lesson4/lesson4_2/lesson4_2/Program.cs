using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Convert.ToString(Console.ReadLine());
            string rev = Reverso(str);
            Console.WriteLine(rev);
            Console.ReadKey();
        }

        private static string Reverso(string str)
        {
            string temp = "";
            for (int i = str.Length-1; i >= 0; i--)
                temp += str[i];
            return temp;
        }
    }
}
