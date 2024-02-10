using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession
{
    internal struct Point
    {
        /// Attributes [Member Value]
        public int X;
        public int Y;

        /// By default at struct compiler will always generate prameter less constructor
        /// To Initialize The Attributes Of The Object With The Default Value Of Attribute DataType
        ///public Point()
        ///{
        ///    X = default;
        ///    Y = default;
        ///}
        ///
        /// We Can Have A Constroct Overloading  
        /// 
        /// Constructor: Is a Spicial Function [Named Always With The Same Name Of Class Or Struct , Has No Return Type]
        /// When U Create User-Defined Constructor , U Must Initialized All Attributes [Member Values] Of This Class Or Struct Inside Its Body

        //Constructor OverLoading
        public Point(int X , int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        //public Point(int _X, int _Y)
        //{
        //    X = _X;
        //    Y = _Y;
        //}
        public Point(int Number)
        {
            X = Y = Number;
        }
        public Point(string Name)
        {
            X = Y = 0;
        }

        // To Edit the behavior of ToString Use [override]
        public override string ToString()
        {
            return $"X = {this.X} , And Y = {this.Y}";
        }

    }
}
