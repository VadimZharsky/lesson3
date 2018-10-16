using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            threeDimentions[] vector = new threeDimentions[2];
            vector[0] = new threeDimentions(3,-2,-1);
            vector[1] = new threeDimentions(1, 2, -5);
            Console.WriteLine(VectorLength(vector));
            Console.ReadKey();
        }

        static double VectorLength(threeDimentions[] vector)
        {
            double diffX = vector[1].x - vector[0].x;
            double diffY = vector[1].y - vector[0].y;
            double diffZ = vector[1].z - vector[0].z;
            double result = Math.Sqrt(Pow(diffX)+ Pow(diffY)+ Pow(diffZ));
            return result;
        }

        private static double Pow(double pow)
        {
            return Math.Pow(pow, 2);
        }
    }
    struct threeDimentions
    {
        public double x, y, z;
        public threeDimentions(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

    }
}