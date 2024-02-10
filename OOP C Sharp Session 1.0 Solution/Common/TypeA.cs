using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    // What you can write inside the namespace?
    // 1. Class
    // 2. Struct [is stand for structure]
    // 3. interface
    // 4. Enum

    // Allowed access modefires inside The NameSpace:
    // 1. internal [] default access modefire  
    // 2. public
    public class TypeA
    {
        // default access modifire inside class or struct is private.
        /*private*/ int X;
        private protected int Y;
        protected int Z;
        internal int I;
        protected internal int J;
        public int K;

    }
}
