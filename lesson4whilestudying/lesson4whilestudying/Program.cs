using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4whilestudying
{
    class Program
    {
        static void Main(string[] args)
        {
            string moving = Convert.ToString(Console.ReadLine());
            try
            {
                char move = Convert.ToChar(moving);
                FigureMove(move);
            }
            catch (Exception e)
            {
                Console.WriteLine("There is more than one movement");
                foreach (char move in moving)
                {
                    FigureMove(move);
                }
            }  
            Console.ReadKey();
        }
        static void FigureMove(char move)
        {
            String replaceTo = "";
            switch (move)
            {
                case 'w':
                    replaceTo = "Move to up";
                    break;
                case 's':
                    replaceTo = "Move to back";
                    break;
                case 'a':
                    replaceTo = "Move to left";
                    break;
                case 'd':
                    replaceTo = "Move to right";
                    break;
                default:
                    Console.WriteLine("Something ain't right");
                    break;
            }
            if (replaceTo!="")
            WriteLineWorker(replaceTo);    
        }
        static void WriteLineWorker(string replaceTo)
        {
            Console.WriteLine("We have to "+replaceTo);
        }
    }
}
