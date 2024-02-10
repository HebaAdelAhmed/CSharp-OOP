using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("I am FullTime Employee");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Employee : ID = {ID} :: Name = {Name} :: Age = {Age} :: Salary = {Salary}");
        }
    }
}
