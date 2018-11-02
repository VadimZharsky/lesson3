using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL6
{
    public static class Chatt
    {
        public static void Chatting()
        {
            FileInfo file = new FileInfo("Chat.txt");
            FileStream fs = file.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(fs, Encoding.Default);
            for (int i = 0; i < 2; i++)
            {
                Console.Write("USer1 is talking: ");
                string temp1 = Console.ReadLine();
                Console.Write("USer2 is talking: ");
                string temp2 = Console.ReadLine();
                writer.WriteLine ($"User1: {temp1}");
                writer.WriteLine($"User2: {temp2}");

            }
            writer.Close();
        }
    }
}
