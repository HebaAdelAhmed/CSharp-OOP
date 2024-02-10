using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession.Inheratince
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int _X , int _Y , int _Z):base(_X , _Y)
        {
            //X = _X ;
            //Y = _Y ;
            Z = _Z ;
        }

        public override string ToString()
        {
            return $"X = {X} :: Y = {Y} :: Z = {Z}";
        }

        public new int Product()
        {
            //return X * Y * Z;
            return base.Product() * Z;
        }
    }
}
