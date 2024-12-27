using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion
        #region Constractor
        //public Point(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}
        //public Point(int num)
        //{
        //    X = num = Y;
        //}
        public override string ToString()
        {
            return $"{X} , {Y}";
        }
        #endregion
    }
}
