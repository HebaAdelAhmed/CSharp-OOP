using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpAdvanced
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int _X , int _Y)
        {
            X = _X ;
            Y = _Y ;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public int CompareTo(Point other)
        {
            if (other == null) return 1 ;
            if (this.X == other.X)
                return this.Y.CompareTo(other.Y);
            else
                return this.X.CompareTo(other.X);
        }
    }
}
