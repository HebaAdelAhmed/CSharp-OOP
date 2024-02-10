using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Interfaces
{
    internal class MyType : IMyType
    {
        public int Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello MyFun From Class");
        }

        public int MyMethod()
        {
            return 2 * 2;
        }

       
    }
}
