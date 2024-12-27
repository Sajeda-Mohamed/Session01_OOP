using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {
        
        public double X; public double Y;
        public Point(double x, double y)
        {
            X = x; Y = y;
        }
        public static double CalcDistance(Point P01, Point P02)
        {
            return Math.Sqrt(Math.Pow(P02.X - P01.X, 2) + Math.Pow(P02.Y - P01.Y, 2));
        }
    }
}
