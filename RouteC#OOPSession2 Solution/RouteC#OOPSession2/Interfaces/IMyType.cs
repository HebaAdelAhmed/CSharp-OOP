using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Interfaces
{
    internal interface IMyType
    {
        /// Default Access Modifires Inside interface Is public 

        /// What U Can Write inside interface ?
        /// 1. Signature For Property [type + name]
        public int Salary { get; set; }
        /// 2. Signature For Method
        public void MyFun();
        public int MyMethod();
        /// 3. Default Implemented Method => C# 8.0 Feature [.Net 3.1 (2019)]
        public void Print()
        {
            Console.WriteLine("Hello, Default Implemented Method");
        }
    }
}
