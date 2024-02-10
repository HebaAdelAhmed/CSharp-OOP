using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Fun01()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void Fun02()
        {
            Console.WriteLine($"Employee : ID = {ID} :: Name = {Name} :: Age = {Age}");
        }
    }
}
