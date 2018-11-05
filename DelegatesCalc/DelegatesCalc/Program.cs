using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCalc
{
    class Program
    {
        public delegate List<string> StringDelegate(List<string> list);
        static void Main(string[] args)
        {

            
            List<string> strings = new List<string>();
            strings.Add("hello");
            strings.Add("world");
            strings.Add("bienvenue");
            strings.Add("nouveau");
            strings.Add("monde");
            List<string> sorted = new List<string>();

            StringDelegate worker = StringWorker.StringWorkerMethod;
            worker += StringWorker.SpaceThroughLetter;
            worker -= StringWorker.SpaceThroughLetter;
            sorted = worker(strings);

            foreach (string s in sorted)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }
    }
}
