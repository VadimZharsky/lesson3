using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Enumerateur(list);
            Creator(list);
            Enumerateur(list);
            list.Sort();
            Enumerateur(list);
            list.Remove(list[list.Count-1]);
            Enumerateur(list);
            object [] arr = list.ToArray(typeof(object)) as object[];
            foreach (object ob in arr)
                Console.WriteLine(ob+" from array[]");
            Console.ReadKey();
        }

        private static void Creator(ArrayList list)
        {
            Random rnd = new Random();
            string letters = "iuwsds sdnsnio opijnn, ksmds,lqwewoi";
            
            for (int i = 0; i < 5; i++)
            {
                string line = "";
                for (int j = 0; j <= (rnd.Next(20, 50)); j++)
                    line += letters[rnd.Next(0, letters.Length-1)];
                list.Add(line);
            }
        }

        private static void Enumerateur(ArrayList list)
        {
            foreach (var str in list)
            {
                Console.WriteLine(str);
                
            }
            Console.WriteLine("------------------");
        }
    }
}
