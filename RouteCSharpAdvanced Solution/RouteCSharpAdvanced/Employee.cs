using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpAdvanced
{
    internal struct Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee PassedEmployee)
        {
            //Employee PassedEmployee = (Employee) obj; // UnSafe casting , May Throw Exeption [Format Exception]
            if (this.Salary > PassedEmployee.Salary)
                return 1;
            else if (this.Salary < PassedEmployee.Salary)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        public static bool operator == (Employee left, Employee right)
        {
            //if((left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary))
            //    return true ;
            //else return false ;
            return left.Equals(right) ;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            //if ((left.Id != right.Id) && (left.Name != right.Name) && (left.Salary != right.Salary))
            //    return true;
            //else return false;
            return !left.Equals(right);
        }
    }
}
