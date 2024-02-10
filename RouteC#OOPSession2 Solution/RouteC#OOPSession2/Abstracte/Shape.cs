using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Abstracte
{

    /// <summary>
    /// Absreact Class : Partial Implementtion For Other Classes    
    /// U Can Not Create an Object [Instance] From an Abstract Class : Not Implemented Complitely
    /// But It Can Be A Reference 
    /// </summary>
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }
        /// <summary>
        /// Abstract Property
        /// </summary>
        public abstract double Parameter { get;  }

        /// <summary>
        /// Abstract Method : = Virtual Method Without Body [Implementation]
        /// </summary>
        public abstract double CalculateArea();
        public virtual void Print()
        {
            Console.WriteLine("Shape");
        }
    }
}
