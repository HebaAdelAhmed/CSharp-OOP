using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Interfaces
{
    internal interface ISeries
    {
        public int Current { get; set; }
        void GetNext();
        public void Reset()
        {
            Current = 0;
        }
    }
}
