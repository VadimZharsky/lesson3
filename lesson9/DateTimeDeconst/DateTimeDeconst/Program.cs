using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDeconst
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            today.Deconst(out string currentTime);
            Console.WriteLine(currentTime);
            Console.ReadKey();
        }
        
    }
     public static class Deconstruct
    {
        
         public static void Deconst(this DateTime today, out string curentTime)
        {
            curentTime = today.TimeOfDay.ToString();
        }
        
    }
}
