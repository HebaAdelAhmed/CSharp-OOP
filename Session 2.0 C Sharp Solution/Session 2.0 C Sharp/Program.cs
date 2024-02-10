using System;
using System.Runtime.Intrinsics.Arm;

namespace Session_2._0_C_Sharp
{
    class Program
    {
        static void Main()
        {
            #region Value type:
            //Console.WriteLine("Hello World!");

            //// Single line comment
            ///*
            // * 
            // * MultiLine comment
            // * 
            // */
            //int Number1;
            ////Allocate to 4 uninitialized bytes at stack.
            ////int : C# keyword
            //Number1 = 10;
            //Console.WriteLine(Number1);

            //Int32 Number2;
            ////Allocate to 4 uninitialized bytes at stack.
            ////Int32 : BCL
            //Number2 = 9;

            //Number2 = Number1; // 10
            //Number1++; // 11
            //Console.WriteLine(Number2);

            #endregion

            #region Reference type:
            //Point p1;
            ////declare for refrence type of type point => in the stack
            ////Zero byte allocated in the heap
            //p1 = new Point();
            ////new
            ////allocate for required bytes at heap.
            ////initialize (cross out) allocated byte of object.
            ////call user defined constractor if exist.
            ////assign reference (p1) to allocated object.

            //Point p2 = new Point();
            ////new
            ////allocate for required bytes at heap.
            ////initialize (cross out) allocated byte of object.
            ////call user defined constractor if exist.
            ////assign reference (p1) to allocated object.

            //p2 = p1;
            //p1.x = 9;
            //Console.WriteLine(p2.x); 
            #endregion

            #region Object:
            //Object O1 = new Object(); 
            //Console.WriteLine(O1.GetHashCode()); // 58225482

            //Object O2 = new Object();
            //Console.WriteLine(O2.GetHashCode()); // 54267293

            //O2 = O1;
            //Console.WriteLine("After Assignment");

            //Console.WriteLine(O1.GetHashCode()); // 58225482
            //Console.WriteLine(O2.GetHashCode()); // 58225482 
            #endregion

            //float x = 30541.451f;
            //decimal y = 54120.545m;
            //// Discard -> For more readability:
            //long Num1 = 10_000_000_000;


            //Parse : [Cast from String to any datatype]
            //Console.WriteLine("Enter yput name: ");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Enter Your Age:");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your salary: ");
            //int Salary = int.Parse(Console.ReadLine());
            //Console.WriteLine("Name : " + Name + " Age :" + Age);

            //Convert : [Cast from any datatype to any datatype]

            int X = 4;
            int Y = 5;
            string Message = "Equation : " + X + " + " + Y + " = " + (X+Y);
            Console.WriteLine(Message);
            // String Formating :
            Message = string.Format("Equation : {0} + {1} = {2}", X , Y , X+Y);
            Console.WriteLine(Message);
            Message = $"Equation : {X} + {Y} = {X+Y}";
            Console.WriteLine(Message);

        }
    }
}
