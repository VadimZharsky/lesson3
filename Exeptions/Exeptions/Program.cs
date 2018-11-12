using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(x);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
