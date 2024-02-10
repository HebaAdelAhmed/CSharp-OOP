using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession
{
    struct Employee
    {
        // default access modifire inside class or struct is private
        int id;
        public string name;
        int age;
        decimal salary;

        // Encapsulation: Seperate Data Defination (Attribute) From Its Use (GetterSetter Or Property)
        public Employee(int id, string name, int age, decimal salary , string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.Address = address;
        }


        // Apply Encapsulation Using Property:
        // Property Is Recommended Because its use is easy like attribute, And at the same time apply encapsulation
        
        // 1. Full Proparty : Have an Attripute
        // [propfull] is snippet for [Full Proparty]
        // Use Full Proparty In case U Need To Make a Vadation Of The Value Of Attribute 
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if(salary >= 8000)
                    salary = value;
            }
        }

        // 2. Automatic Proparty
        // [prop] is snippet for [Automatic Proparty]
        // Use an Automatic Proparty If U Don't need to make a validation
        // Compiler Will Generate Backing Field [Hidden Private Attreibuete]
        public string Address { get; set; }

        // If U Need a Read Only Proparty Use [Full Property and Remove set]

        //Apply Encapsulation Using Getter and Setter: 
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            if (id >= 1 && id <= 1001)  // Control [Validate] Value
                this.id = id;
        }


        public override string ToString()  // Defaullt : RouteC_OOPSession.Employee
        {
            return $"Id Of Employee Is = {id} \nName Of Employee Is = {name} \nAge Of Employee Is = {age} \nAnd Salary Of This Employee is = {Salary}";
        }
    }
}
