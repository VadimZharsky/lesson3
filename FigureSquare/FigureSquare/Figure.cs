using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    public abstract class Figure
    {
        public abstract double CalculateArea();

    }
    public class Triagle : Figure
    {
        public double _base { get; set; }
        public override double CalculateArea()
        {
            return _base * (_base / 2);
        }
    }
    public class Circle : Figure
    {
        private const double pi = 3.14;
        public double rad { get; set; }
        public override double CalculateArea()
        {
            return rad * rad * pi;
        }
    }
    public class Square : Figure
    {
        public double side { get; set; }
        public override double CalculateArea()
        {
            return side*side;
        }
    }
}
