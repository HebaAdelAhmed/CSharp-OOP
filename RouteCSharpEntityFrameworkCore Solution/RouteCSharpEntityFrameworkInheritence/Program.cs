using RouteCSharpEntityFrameworkInheritence.Contexts;
using RouteCSharpEntityFrameworkInheritence.Entities;
using System.Linq;
using System;

namespace RouteCSharpEntityFrameworkInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyContext context = new CompanyContext();

            FullTimeEmployee FE01 = new FullTimeEmployee() { Name = "Heba Adel Ahmed" , Address = "ElZiton" , Age = 23 , Salary = 7000 , StartDate = DateTime.Now};
            PartTimeEmployee PE01 = new PartTimeEmployee() { Name = "Asmaa Esam", Address = "Shoubra", Age = 24, CountOfHours = 44, HourRate = 150 };

            //// Added in Local
            //context.FullTimeEmployees.Add(FE01);
            //context.PartTimeEmployees.Add(PE01);

            //// Added in Datebases
            //context.SaveChanges();

            var fullTimeEmployee = from F in context.FullTimeEmployees
                                   select F;
            foreach (var f in fullTimeEmployee)
                Console.WriteLine($"{f.Id} :: {f.Name} :: {f.Age} :: {f.Salary} :: {f.StartDate}");

            var partTimeEmployee = from P in context.PartTimeEmployees
                                   select P;
            foreach (var p in partTimeEmployee)
                Console.WriteLine($"{p.Id} :: {p.Name} :: {p.Age} :: {p.HourRate} :: {p.CountOfHours}");
        }
    }
}
