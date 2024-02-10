using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2
{

    /// <summary>
    /// Static Class : 
    /// Is A Just Container For Static Member [Attribute , Property , Constructor , Method]
    /// and Constant
    /// U Can't Create Object From This Class (Helper Class)
    /// No Inheretance From This Class
    /// </summary>
    static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //private static double pi;
        /// <summary>
        /// Any Static Attribute , Compiler Will Initialize It With The Defult Value Of Its DataType 
        /// pi = 0;
        /// </summary>

        // Class Member Property : [Static Property] -> Called Through Class Name Does Not Depend On Object State
        // Must Return On Of These:
        // 1. Static Attribute
        // 2. Const [Recommened]
        public const double pi = 3.14;
        public static double PI
        {
            get { return pi; }
            //set { pi = value; }
        }

        // 1. Oject Constructot
        //public Utility(int _X, int _Y)
        //{
        //    X = _X;
        //    Y = _Y;
        //    //pi = 3.14; Is Not the Right Place To Initialize the static attributes
        //}

        // 2. Class Constractor [Static Constractor] : Maximum Only One Static Constructor Per Class
        // Can't Spicifiy Access Modfires Or Parameters For Static Constractor
        // Will Be Executed Just Only One Time Per Class LifeTime Before The First Usage Of Class 
        // Usage Of Class:
        // 1. Call Static Method Or Static Proprerty 
        // 2. Create Object From This Calss
        // 3. Create Object From Another Class Inheriting From This Class

        //static Utility()
        //{
        //    pi = 3.14;
        //}// To Initatlize the static Attribute Of The Class 

        // Object Member Method
        //public double CmToInch(double Cm)
        //{
        //    return Cm / 2.54;
        //}

        // Class Member Method : [Static Method] -> Called Through Class Name  
        public static double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }

        public static double CircleArea(double Radius)
        {
            return PI * Radius * Radius;
        }
    }
}
