using RouteC_OOPAssignment1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPAssignment1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public HiringDate HiringDate { get; set; }
        public SecurtyLevels SecurtyLevels { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} :: Name: {Name} :: Salary: {Salary}$ :: Gender: {Gender} :: Securty Level: {SecurtyLevels}";
        }

        public static Employee[] GetEmployeeArrFromUser(int LengthOfArray) 
        {
            if (LengthOfArray < 1) return null;

            Employee[] arr = new Employee[LengthOfArray];

            return arr;
        }

        public static void FillDataFromUser(Employee[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
            {
                Console.WriteLine($"Enter The Data Of Employee Number: {i+1}");
                arr[i] = new Employee();
                bool Flag;
                do
                {
                    Console.Write("Enter Id: ");
                    Flag = int.TryParse(Console.ReadLine() , out int id);
                    arr[i].Id = id;
                } while (!Flag);
                
                Console.Write("Enter Name: ");
                arr[i].Name = Console.ReadLine();
                do
                {
                    Console.Write("Enter Salary: ");
                    Flag = decimal.TryParse(Console.ReadLine() , out decimal salary);
                    arr[i].Salary = salary;
                } while (!Flag);
                do
                {
                    Console.Write("Enter Gender: ");
                    string empGender = Console.ReadLine();
                    Flag = Enum.TryParse(typeof(Gender), empGender, true, out object enumValue01);
                    arr[i].Gender = (Gender)enumValue01;
                } while (!Flag);
                Console.WriteLine("Enter Hiring Date: ");
                arr[i].HiringDate = new HiringDate();
                do
                {
                    Console.Write("Day: ");
                    Flag = int.TryParse(Console.ReadLine(), out int day);
                    arr[i].HiringDate.Day = day;
                }while (!Flag);
                do
                {
                    Console.Write("Month: ");
                    Flag = int.TryParse(Console.ReadLine(), out int month);
                    arr[i].HiringDate.Month = month;
                } while (!Flag);
                do
                {
                    Console.Write("Year: ");
                    Flag = int.TryParse(Console.ReadLine(), out int year);
                    arr[i].HiringDate.Year = year;
                } while (!Flag);
                do
                {
                    Console.Write("Enter Securty Level: ");
                    string empSecurtyLevel = Console.ReadLine();
                    Flag = Enum.TryParse(typeof(SecurtyLevels), empSecurtyLevel, true, out object enumValue02);
                    arr[i].SecurtyLevels = (SecurtyLevels)enumValue02;
                } while (!Flag);
            }
        }

        public static void PrintArrDataOfEmployee(Employee[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
            {
                Console.WriteLine($"{arr[i].Id} :: {arr[i].Name} :: {arr[i].Salary} :: {arr[i].Gender} :: {arr[i].SecurtyLevels}");
            }
        }
    }
}
