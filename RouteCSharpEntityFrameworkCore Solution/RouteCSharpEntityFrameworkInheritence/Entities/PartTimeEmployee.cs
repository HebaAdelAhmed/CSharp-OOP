using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEntityFrameworkInheritence.Entities
{
    internal class PartTimeEmployee : Employee
    {
        public int HourRate { get; set; }
        public int CountOfHours { get; set; }
    }
}
