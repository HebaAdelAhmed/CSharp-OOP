using System;

namespace DataTypeSession
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Value Type DataType
            //int X;
            //// Allocate for uninitialized 4 Bytes in stack
            //// int: C# Keyword
            //X = 10;

            //Int32 Y;
            //// Allocate for uninitialized 4 Bytes in stack
            ////Int32: BCL Keyword
            //Y = 20;
            //X=Y; // X= 20 , Y= 20
            //Y++; // X=20 , Y = 21
            //Console.WriteLine(Y); 
            #endregion

            #region Reference Type DataType

            //Point P1;
            //// Zero Byte allocated at heap.
            //// Declare For reference of type Point. 
            //// Reference for (P1) is allocate at stack
            //P1 = new Point();
            //// new:
            //    // allocate for Required bytes at heap.
            //    // initialize (Cross Out) Allocated bytes of object.
            //    // Call user defined constractor if exist.
            //    // Assign Reference (P1) to allocated object

            //Point P2 = new Point();
            //// new:
            //    // allocate for Required bytes at heap.
            //    // initialize (Cross Out) Allocated bytes of object.
            //    // Call user defined constractor if exist.
            //    // Assign Reference (P2) to allocated object
            //P1.x = 10;
            //P1.y = 20;

            //P2 = P1;
            //// P2 -> P1:
            //    // P2.x = 10;
            //    // P2.y = 20;
            //    // P1.x = 10;
            //    // P1.y = 20;
            //Console.WriteLine(P2.y);

            #endregion

            #region Object

            //Object O1 = new Object();
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 1;
            //Console.WriteLine(O1.GetHashCode());
            //O1 = 'A';
            //Console.WriteLine(O1.GetHashCode());
            //O1 = new Point(); 
            //Console.WriteLine(O1.GetHashCode());
            //Console.WriteLine("O2 Is Added:");
            //Object O2 = new Object();  // Unratchable Object
            //Console.WriteLine(O2.GetHashCode());
            //Console.WriteLine("After O2 = O1:");
            //O2 = O1;
            //Console.WriteLine(O2.GetHashCode());

            #endregion

            #region Dicimal And Descard
            //float X = 1.0f;
            //decimal Y = 515631.545m;
            //double Z = 1.5; // Default
            //long Num1 = 100_000_000; // Descard -> For more readablility. 
            #endregion

            #region Value Type Casting

            //int X = 10;
            //long Y = X; // 1. Implicit Casting (Safe Casting).

            //long X = 100;
            //// int Y = X; // Error
            //int Y = (int) X; // Explicit Casting (Safe Casting). -> if value is long it will return any value not an error

            // For return an exception:
            //long X = 10000000005463520;
            //int Y;
            //checked
            //{
            //    Y = (int)X;
            //}
            //Console.WriteLine(Y);

            //int X = 100;
            //double Y = X; // Implicit casting (Safe Casting)
            //Console.WriteLine(Y);

            //double X = 99.022;
            //int Y = (int)X; // Explicit Casting (Unsafe Casting)
            //Console.WriteLine(Y);

            //double X = 99.022;
            //int Y;
            //checked
            //{
            //    Y = (int)X; // Explicit Casting (Unsafe Casting) // Not an exception.
            //}
            //Console.WriteLine(Y);

            // Parse : is to cast from string to any other data type:
            //Console.WriteLine("Please Enter Your Name : ");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Entre Your Salary: ");
            //decimal Salary = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("======================");
            //Console.WriteLine($"Hello {Name} , Your Age Is : {Age} and your salary is : {Salary}");

            //Convert : is to cast from any data type to any other data type:
            //Console.WriteLine("Please Enter Your Name : ");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Entre Your Salary: ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("======================");
            //Console.WriteLine($"Hello {Name} , Your Age Is : {Age} and your salary is : {Salary}");

            //string Flag1 = "True";
            //bool X1 = Convert.ToBoolean(Flag1);
            //Console.WriteLine(X1);

            //string Flag2 = "Hamada";
            //bool X2 = Convert.ToBoolean(Flag2); // Error
            //Console.WriteLine(X2);
            #endregion

        }
    }
}
