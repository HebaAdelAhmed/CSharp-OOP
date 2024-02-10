using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Polymorphism_Override
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("I am PartTime Employee");
        }
        public override void Fun02()
        {
            Console.WriteLine($"Employee : ID = {ID} :: Name = {Name} :: Age = {Age} :: Hour Rate = {HourRate} :: Count Of Hour = {CountOfHours}");
        }
    }
}
