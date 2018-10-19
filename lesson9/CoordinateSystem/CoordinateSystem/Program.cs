using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
    static class Program
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
            var (x1, y1, z1) = vector[0];
            var (x2, y2, z2) = vector[1];
            double diffX = x2 - x1;
            double diffY = y2 - y1;
            double diffZ = z2 - z1;
            double result = Math.Sqrt(diffX.Pow() + diffY.Pow()+ diffZ.Pow());
            return result;
        }

        private static double Pow(this double pow)
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
        public void Deconstruct(out double X, out double Y, out double Z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}