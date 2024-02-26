using RouteCSharpEntityFramework.Contexts;
using RouteCSharpEntityFramework.Entities;
using System;
using System.Linq;

namespace RouteCSharpEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EnterpriseContext context = new EnterpriseContext() ;
            Employee Emp01 = new Employee() { Name = "Ahmed" , Age = 27 , Salary = 20000 , EmailAddress = "Ahmed@gmail.com"};
            Employee Emp02 = new Employee() { Name = "Heba", Age = 23, Salary = 15000, EmailAddress = "Heba@gmail.com" };
            Employee Emp03 = new Employee() { Name = "Hala", Age = 25, Salary = 15000, EmailAddress = "Hala@gmail.com" };

            //Console.WriteLine(context.Entry(Emp01).State); // Detached

            #region Insert
            //// Add To Local
            //Console.WriteLine("After Added:");
            //context.Employees.Add(Emp01);
            //context.Set<Employee>().Add(Emp01);
            //context.Add(Emp02);
            //Console.WriteLine(context.Entry(Emp01).State); // Added
            //context.Add(Emp03);
            //context.SaveChanges();


            //// Add To Database
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Emp01).State); // UnChanged 
            #endregion

            #region Select
            //var employee = (from E in context.Set<Employee>()
            //                where E.EmpId == 4
            //                select E).FirstOrDefault(); 
            #endregion

            #region Update
            //Console.WriteLine(employee?.Name ?? "Not Found");

            //Console.WriteLine(context.Entry(employee).State); // Unchanged
            //employee.Name = "Halola";
            //Console.WriteLine(context.Entry(employee).State); // Modified
            //// Update In Database
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(employee).State); // Unchanged 
            #endregion

            #region Delete
            //// Remove From Local
            //context.Employees.Remove(employee);
            //// Remove From Database
            //context.SaveChanges(); // UnAttached
            //var Result = from E in context.Set<Employee>()
            //             select E;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}
