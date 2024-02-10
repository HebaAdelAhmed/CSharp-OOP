using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A , int _B):base(_A)
        {
            B = _B;
        }
        // Override:
        // 1. Apply Function Override Using [new] Keyword
        // Static Binding Method -> Because of Using 'new' Keyword
        public new void Fun01 ()
        {
            Console.WriteLine("I am Derived [Child]");
        }
        // 2. Apply Function Override Using [override] Keyword
        // But Before Anything , The Function That Will Be Overrided Using "override" Should Be [public and virtual] In The Parent Class
        // Dynamic Binding Method -> Because Of Using 'override' Keyword
        public override void Fun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }
        public void Fun03()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }
    }
}
