using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeC : TypeA
    {
        public TypeC() 
        {
            B = 10; // B -> Could be access because it is private protected [private protected can be access from other class in case of inheretence and in the same project]
            C = 20; // C -> Could be access because it is protected [protected can be access in case of inheretence in the same project or others]
            D = 30; // D -> Could be access because it is internal [internal can be access in case of it is in the same project]
            E = 50; // E -> Could be access because it is internal protected [intenal protected can be access in these cases : in the same project or in case of inheretence]
            F = 60; // F -> Could be access because it is public [public can be access from anywhere]
        }
    }
}
