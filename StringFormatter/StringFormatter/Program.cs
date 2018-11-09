using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatter
{
    class Program
    {
        public delegate string stringFormatter(string str);
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("Everybody have to know advanced english");
            strings.Add("Here is bad news. quant a moi je parle francais");
            strings.Add("A long time ago in a galaxy far, far away");
            strings.Add("faraway I'll understand how to code");
            strings.Add("C sharp... Try to use your mind completely");

            stringFormatter formatter = null;
            strings = formatter.StringWorker(strings);
            foreach (string s in strings)
            {
                    Console.WriteLine(s);
            }
            Console.ReadKey();
        }

    }
}
