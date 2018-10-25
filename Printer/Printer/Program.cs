using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input new text below: ");
            string toPrint = Console.ReadLine();
            Console.WriteLine("Select a favourite way to print it:\n1.To Console\n2.To a new file\n3.To an image ");
            byte choise = Convert.ToByte(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    ToConsole print1 = new ToConsole() { text = toPrint };
                    print1.Print();
                    break;

                case 2:
                    ToFile print2 = new ToFile() { text = toPrint };
                    print2.Print();
                    break;

                case 3:
                    ToImage print3 = new ToImage() { text = toPrint };
                    print3.Print();
                    break;
            }
            Console.ReadKey();
        }
    }
}
