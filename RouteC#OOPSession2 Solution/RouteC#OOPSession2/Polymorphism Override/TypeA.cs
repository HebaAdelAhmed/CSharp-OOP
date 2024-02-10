using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }

        public void Fun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }
}
