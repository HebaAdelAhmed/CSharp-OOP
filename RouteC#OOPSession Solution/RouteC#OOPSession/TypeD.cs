using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace RouteC_OOPSession
{
    internal class TypeD : TypeA
    {
        public TypeD() 
        {
            //B = 10; // Invalid cause it is not in the same project [private protected]
            C = 20; // Valid cause it is [protected]
            //D = 30; // Incalid cause it is not in the same project [internal]
            E = 20; // Valid cause it is [internal protected]
            F = 20; // Valid case it is [public]

        }
    }
}
