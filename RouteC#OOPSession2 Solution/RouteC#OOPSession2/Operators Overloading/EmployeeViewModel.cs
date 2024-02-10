using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Operators_Overloading
{
    // This Calss Will Be Rendered For The End-User As View Model [HTML]
    internal class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static /*EmployeeViewModel*/ explicit operator EmployeeViewModel (Employee employee)
        {
            string[] Names = employee.FullName.Split (' ');
            return new EmployeeViewModel()
            {
                FirstName = Names[0],
                LastName = Names[1],
            };
        }
    }
}
