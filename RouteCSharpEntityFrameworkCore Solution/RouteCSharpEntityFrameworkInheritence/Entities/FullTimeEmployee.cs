using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFrameworkInheritence.Entities
{
    internal class FullTimeEmployee : Employee
    {
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
    }
}
