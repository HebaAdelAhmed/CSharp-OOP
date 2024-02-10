using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB() 
        {
            TypeA typeA = new TypeA();
            typeA.D = 30; // can be access because it is the same project (D -> is Internal)
            typeA.E = 40; // can be access becaues it is the same project (E -> is internal protected)
            typeA.F = 50; // can be access because it is (F -> is public)

        }
       
    }
}
