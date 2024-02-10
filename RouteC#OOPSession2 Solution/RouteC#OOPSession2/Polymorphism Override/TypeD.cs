using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class TypeD: TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C , int _D) : base(_A, _B , _C)
        {
            D = _D;
        }
        public new virtual void Fun02() // Chain is Bracked
        {
            Console.WriteLine($"TypeD : A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }
}
