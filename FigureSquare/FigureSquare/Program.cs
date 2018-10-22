using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[10,3];
            for (int i=0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0) { matrix[i, j] = new Square() { side = i + 1 }.CalculateArea(); }
                    if (j == 1) { matrix[i, j] = new Triagle() { _base = i + 1 }.CalculateArea(); }
                    if (j == 2) { matrix[i, j] = new Circle() { rad = i + 1 }.CalculateArea(); }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i,j]+"||");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
