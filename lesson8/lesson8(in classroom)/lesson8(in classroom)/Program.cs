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
            
            var v = new massive(new char [4,4]
                {
                    { '|', '-', '\\', ' '},
                    { '|', ' ', '/', ' '},
                    { '|', ' ', '\\', ' '},
                    { '|', ' ', '/', ' '},
                });
            var a = new massive(new char[4, 4]
                {
                    { '/', '-', '\\', ' '},
                    { '|', ' ', '|', ' '},
                    { '|', '-', '|', ' '},
                    { '|', ' ', '|', ' '},
                });
            var d = new massive(new char[4, 4]
                {
                    { '|', '-', '\\', ' '},
                    { '|', ' ', '|', ' '},
                    { '|', ' ', '|', ' '},
                    { '|', '-', '/', ' '},
                });
            var i = new massive(new char[4, 4]
                {
                    { '-', '|', '-', ' '},
                    { ' ', '|', ' ', ' '},
                    { ' ', '|', ' ', ' '},
                    { '-', '|', '-', ' '},
                });
            var m = new massive(new char[4, 4]
                {
                    { '|', '-', '\\', ' '},
                    { '|', '|', '|', ' '},
                    { '|', '|', '|', ' '},
                    { '|', '|', '|', ' '},
                });
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(i.arr[j, k]+" ");
                }
                Console.WriteLine("");
            }
            
            Console.ReadKey();
        }
    }
    public struct massive
    {
        public char[,] arr;
        public massive(char[,] arr)
        {
            this.arr = arr;
        }
    }
}
