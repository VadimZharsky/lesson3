using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_in_classroom_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var v = new massive('v', new char [4,4]
                {
                    { '|', '|', ' ', ' '},
                    { '|', '|', ' ', ' '},
                    { '|', '|', ' ', ' '},
                    { '\\', '/', ' ', ' '},
                });
            var a = new massive('a', new char[4, 4]
                {
                    { '/', '-', '\\', ' '},
                    { '|', ' ', '|', ' '},
                    { '|', '-', '|', ' '},
                    { '|', ' ', '|', ' '},
                });
            var d = new massive('d', new char[4, 4]
                {
                    { '|', '-', '\\', ' '},
                    { '|', ' ', '|', ' '},
                    { '|', ' ', '|', ' '},
                    { '|', '-', '/', ' '},
                });
            var i = new massive('i', new char[4, 4]
                {
                    { '-', '|', '-', ' '},
                    { ' ', '|', ' ', ' '},
                    { ' ', '|', ' ', ' '},
                    { '-', '|', '-', ' '},
                });
            var m = new massive('m', new char[4, 4]
                {
                    { '|', '-', '\\', ' '},
                    { '|', '|', '|', ' '},
                    { '|', '|', '|', ' '},
                    { '|', '|', '|', ' '},
                });
            massive[] alfabet = new massive[]
                {
                    v,a,d,i,m
                };
            writeLetters(alfabet);
            Console.ReadKey();
        }
        public static void writeLetters(massive[] name)
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (var ch in name)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(ch.arr[i, j]);
                    }

                    Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }
    public struct massive
    {
        public char[,] arr;
        public char letterName;
        public massive(char letterName, char[,] arr)
        {
            this.letterName = letterName;
            this.arr = arr;
        }
    }
}
