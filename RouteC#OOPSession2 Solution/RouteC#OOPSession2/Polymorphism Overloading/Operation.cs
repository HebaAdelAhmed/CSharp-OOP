using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Overloading
{
    internal class Operation
    {

        // Overloading
        public static int Sum(int X, int Y)
        {
            return X + Y;
        }
        public static int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        public static double Sum(double X , double Y)
        {
            return X + Y;
        }
        public static double Sum(double X, double Y , double Z)
        {
            return X + Y + Z;
        }
    }
}
