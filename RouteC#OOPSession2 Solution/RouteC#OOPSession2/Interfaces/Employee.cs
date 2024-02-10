using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Interfaces
{
    class Employee : ICloneable, IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public object Clone()
        {
            return new Employee() { Id = this.Id, Name = this.Name, Salary = this.Salary };
        }


        /// +1 : this.Salary > other.Salary
        /// -1 : this.Salary < other.Salary
        ///  0 : this.Salary = other.Salary

        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary)
                return +1;
            else if (this.Salary < other.Salary)
                return -1;
            else 
                return 0;
        }

        public override string ToString()
        {
            return $"Employee = {Id} :: {Name} :: {Salary}";
        }
    }
}
