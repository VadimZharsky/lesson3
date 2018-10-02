using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_0
{
    class Program
    {
        static void Main(string[] args)
        {

            akinator();
            Console.ReadKey();
        }
        static void akinator()
        {
            Console.WriteLine("Akinator from 0 to 100");
            int maxEdge = 100;
            int minEdge = 0;
            int average = maxEdge / 2;
            Console.WriteLine($"your number is greater than {average}?\n1.yes\n2.no\n3.No, my answer is equal to {average}");
            byte choise = Convert.ToByte(Console.ReadLine());
            if (choise == 1){average = StepUp(maxEdge, minEdge,average);}
            if (choise == 2){average = StepDown(maxEdge, minEdge, average);}
            Console.WriteLine("Your number is {0}", average);

        }
        static int StepUp(int maxEdge, int minEdge, int average)
        {
            minEdge = average;
            average = (maxEdge + minEdge)/2;
            Console.WriteLine("Should be your number is between {0} and {1}", maxEdge, minEdge);
            Console.WriteLine($"your number is greater than {average}?\n1.yes\n2.no\n3.No, my answer is equal to {average}");
            byte choise = Convert.ToByte(Console.ReadLine());
            if (choise == 1 && !(maxEdge - minEdge <= 2)) { return StepUp(maxEdge, minEdge, average); }
            if (choise == 1 && (maxEdge - minEdge <= 2)) { return average + 1; }
            if (choise == 2 && !(maxEdge - minEdge <= 2)) { return StepDown(maxEdge, minEdge, average); }
            if (choise == 2 && (maxEdge - minEdge <= 2)) { return average; }
            else { return average; }
        }

        static int StepDown(int maxEdge, int minEdge, int average)
        {
            maxEdge = average;
            minEdge = (average == 50) ? 0 : minEdge;
            average = (maxEdge + minEdge) / 2;
            Console.WriteLine("Should be your number is between {0} and {1}", maxEdge, minEdge);
            Console.WriteLine($"your number is greater than {average}?\n1.yes\n2.no\n3.No, my answer is equal to {average}");
            byte choise = Convert.ToByte(Console.ReadLine());
            if (choise == 1 && !(maxEdge - minEdge <= 2)) { return StepUp(maxEdge, minEdge, average); }
            if (choise == 1 && (maxEdge - minEdge <= 2)) { return average + 1; }
            if (choise == 2 && !(maxEdge-minEdge<=2)) { return StepDown(maxEdge, minEdge, average); }
            if (choise == 2 && (maxEdge - minEdge <= 2)) { return average; }
            else { return average; }
        }
    }
}
