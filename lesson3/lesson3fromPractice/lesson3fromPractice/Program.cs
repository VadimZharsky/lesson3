using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3fromPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   please select an exercise 1)1-5 or 2)6-7 ");
            byte selected = Convert.ToByte(Console.ReadLine());
            if (selected == 1) { WithTwoNumbers(); }
            else if (selected == 2) { WithFiveNumbers(); }
            else { Console.WriteLine("Something ain't right. Sorry about that(("); }
            Console.WriteLine("press any key to exit from here");
            Console.ReadKey();
        }

        private static void WithFiveNumbers()
        {
            Console.WriteLine("enter an expression including five numbers for addition then result");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            int fourth = Convert.ToInt32(Console.ReadLine());
            int fifth = Convert.ToInt32(Console.ReadLine());
            int answer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = first + second + third + fourth + fifth;
            Comparateur(answer, correctAnswer);
        }
        private static void WithTwoNumbers()
        {
            Console.WriteLine("enter an expression then result");
            int first = Convert.ToInt32(Console.ReadLine());
            char operate = Convert.ToChar(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int answer = Convert.ToInt32(Console.ReadLine());          
            int correctAnswer = (operate=='+')?first+second:first-second;
            Comparateur(answer, correctAnswer);           
        }
        static void Comparateur(int answer, int correctAnswer)
        {
            bool verificate = (correctAnswer == answer) ? true : false;
            Console.WriteLine(verificate);
            if (verificate == false)
            {
                string lessGreat = (correctAnswer > answer) ? "Your answer is less than result" : "Your answer is greater than result";
                Console.WriteLine(lessGreat);
                byte trying = 2;
                while (verificate == false && trying > 0)
                {
                    Console.WriteLine("Try more. You still have {0} attempt(s)", trying);
                    answer = Convert.ToInt32(Console.ReadLine());
                    verificate = (correctAnswer == answer) ? true : false;
                    if (verificate == false)
                    {
                        Console.WriteLine(verificate);
                        lessGreat = (correctAnswer > answer) ? "Your answer is less than result" : "Your answer is greater than result";
                        Console.WriteLine(lessGreat);
                    }
                    trying--;
                }
            }
            string finished = (verificate == true) ? "Congratulations! you've just won!" : "sorry, all is wasted";
            Console.WriteLine(finished);
        }
    }
}
