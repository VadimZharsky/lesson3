using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCommand.Command();
            Console.ReadKey();
        }
        public static double FullDuration(List<double> duration)
        {
            double full = 0;
            foreach (double d in duration)
            {
                int temp = (int)d;
                double remainder = d - temp;
                remainder *= 100;
                temp *= 60;
                double inSec = temp + remainder;
                full += inSec;
                Console.WriteLine($"start: {d},, inSec: {inSec}");
            }
            
            return 0;
        }
    }
}
