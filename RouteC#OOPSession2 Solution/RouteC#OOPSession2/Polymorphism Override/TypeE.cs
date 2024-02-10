using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _A, int _B, int _C, int _D , int _E) : base(_A, _B, _C , _D)
        {
            E = _E;
        }
        public override void Fun02()
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");
        }
    }
}
