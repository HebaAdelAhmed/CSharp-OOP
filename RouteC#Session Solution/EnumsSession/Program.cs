using System;

namespace EnumsSession
{

    enum Gender
    {
        Male,
        Female,
    }
    enum Grades
    {
        A, B, C, D, F // Labels
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grades grades = Grades.A;
            //if (grades == Grades.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine(":(");

            Grades G01 = (Grades) 1;
            Console.WriteLine(G01);
        }
    }
}
