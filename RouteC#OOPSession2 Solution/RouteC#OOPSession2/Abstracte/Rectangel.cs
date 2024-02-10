using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Abstracte
{
    internal class Rectangel : Shape
    {
        
        public override double Parameter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
        //public override double Parameter
        //{
        //    get => parameter;
        //    set => parameter = (Dim01 + Dim02) * 2;
        //}

        public override double CalculateArea()
        {
            return Dim01 * Dim02;
        }
        public override void Print()
        {
            Console.WriteLine("Rectangel") ;
        }
    }
}
