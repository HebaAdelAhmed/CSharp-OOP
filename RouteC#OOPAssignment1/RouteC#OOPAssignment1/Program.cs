using System;

namespace RouteC_OOPAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] ArrOfEmployees = Employee.GetEmployeeArrFromUser(3); 
            Employee.FillDataFromUser(ArrOfEmployees);
            Console.Clear();
            Employee.PrintArrDataOfEmployee(ArrOfEmployees);
        }
    }
}
