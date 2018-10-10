using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. считает, сколько символов у стринг. если 13 и более то обрезает
            //2. работа со стихотворением
            Texter("Select a part from practice:\n1.Task with String\n2.Task with a poem");
            byte choise = Convert.ToByte(Console.ReadLine());
            if (choise == 1) { StringWorker(); }
            if (choise == 2) { PoemWorker(); }
            Console.ReadKey();
        }

        private static void StringWorker()
        {
            Texter("\nEnter some phrase below: ...");
            string phrase = Console.ReadLine();
            if (phrase.Length > 13)
            {
                phrase = $"{phrase.Remove(13)}...";
                Texter(phrase);
            }
            else {Texter(phrase); }
        }

        private static void PoemWorker()
        {
            Texter("\nsome poem...");
            string conveyor = "цй укеооонллгшщ зхллъфыв атттпр олд жэоячс мить бю.";
            char[] splitter = conveyor.ToCharArray();
            string poem ="";
            Random rnd = new Random();
            for (int i = 0; i < (rnd.Next(4, 8)); i++)
            {
                for(int j = 0; j<=(rnd.Next(20,50));j++)
                    poem += splitter[rnd.Next(0,conveyor.Length-1)];
                poem += ',';
            }
            Texter(poem);
            Texter("");
            string[] separated = poem.Split(',');
            for (int i = 0; i<separated.Length-1;i++)
            {
                separated[i] = insertor(separated[i], 0);
                separated[i] = separated[i].Replace("л","ЛЬ");
                separated[i] = separated[i].Replace("о", "А");
                separated[i] = separated[i].Replace("ть", "Т");
                Texter(separated[i].TrimStart());
            }
               
        }
        private static string insertor(string s, int index)
        {
            if (s.IndexOf('т',index)>=0)
            {
                int ind = s.IndexOf('т', index+1);
                if (ind < 0) {{ return s; } }
                s = s.Insert(ind + 1, "ь");
                return insertor(s, ind);
            }
            else { return s; }
        }
        public static void Texter(string s)
        {
            Console.WriteLine(s);
        }
    }
}
