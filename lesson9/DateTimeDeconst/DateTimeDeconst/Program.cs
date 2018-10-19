using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace DateTimeDeconst
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 0; i < 60; i++)
            {
                DateTime today = DateTime.Now;
                var (_, _, hours, minutes, seconds) = today;
                string usType = "";
                if (hours >= 13)
                {
                    usType = "PM";
                    hours -= 12;
                }
                else { usType = "AM"; }
                Console.WriteLine("{0}:{1}:{2} {3}", hours, minutes, seconds, usType);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
    public static class DeconstructDateTime
    {
        public static void Deconstruct(this DateTime today,out int year, out int day, out int hour, out int min, out int sec)
        {
            year = today.Year; 
            day = today.Day;
            hour = today.Hour;
            min = today.Minute;
            sec = today.Second;
        }
    }
}
