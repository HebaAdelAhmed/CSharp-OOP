using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int _A , int _B , int _C):base(_A , _B)
        {
            C = _C;
        }

        public new void Fun01()
        {
            Console.WriteLine("I am Grand Child");
        }
        public override void Fun02()
        {
            Console.WriteLine($"TypeC => A = {A} , B = {B} , C = {C}");
        }
    }
}
