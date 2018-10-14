using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8Enums
{
    class Program
    {
        enum dayz
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.DayOfWeek);
            if (today.DayOfWeek.ToString() == dayz.Monday.ToString())
                Console.WriteLine((int)dayz.Monday);
            Console.ReadKey();
        }
    }
}
