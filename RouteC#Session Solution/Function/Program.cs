using System;

// in one solution we could put in it many project.

namespace Function /// Name of Project 
{
    /// Could Write in namespace 3 things :
    /// 1. Class 
    /// 2. Struct
    /// 3. Enum
    /// 4. Interface


    internal class Program
    {

        /// Passing By Value -> Read Only
        /// Passing By Reference -> Read First then Write (Parameters Passed By Reference Must be Initialized [Before Passed])
        /// Passing By Out -> Write First and Then Read (Parameters Passed By Recerence Could Be Initiale Or Not) -- Must be Initialized [Inside Function]
        /// 
        /// 
        /// Entry Point
        static void Main(string[] args)
        {

            //Print(30 , '$'); // Passing Parameter Using Order.
            //Print(Pattern: 'X' , Count: 50); // Passing Parameter Using Name.
            //Console.WriteLine("Hello\nAhmed");
            //Console.WriteLine("Hello\nHeba\tAdel");
            //string FolderPath = "E:\\Courses\\ASP.Net\\02 C#\\Session 04\\Videos";
            //FolderPath = @"E:\Courses\ASP.Net\02 C#\Session 04\Videos";
            //Console.WriteLine(FolderPath);
            //Print(Count:20 , Pattern: @"/*\");

            #region Passing a Value type
            //int Num01 = 20;
            //int Num02 = 50;
            //Swap(Num01, Num02); // -> Affect will happen in Swap Function only ont in main function.
            //Swap(ref Num01, ref Num02); // -> Affect will happen in both.
            //Console.WriteLine($"Outside Swap Function : Numbwr01 = {Num01} , And Number02 = {Num02}");
            #endregion

            #region Passing a Reference Type
            //int[] Arr01 = { 10, 20, 30, 40 };
            ////Arr01 = default;
            //Console.WriteLine(SumOfArray(Arr: Arr01));
            //Console.WriteLine(Arr01[0]); 
            #endregion

            #region Passing By OUT

            //int X = 10 , Y = 20 , SResult , MResult ;
            //SumAndMultiplay(Number01: X , Number02: Y , Sum: out SResult , Multiplay: out MResult);
            //Console.WriteLine($"Sum = {SResult} , Multiplication = {MResult}");

            #endregion

            #region Params:

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int Sum = SumArr(Numbers);
            //int Sum = SumArr(1, 2, 3, 4, 5, 6, 7, 8);
            //Console.WriteLine(Sum);

            #endregion
        }

        public static void Print()
        {
            for (int i = 0; i < 10; i++)
                Console.Write('@');
            Console.WriteLine();
        }
        public static void Print(int Count = 10, string Pattern = "#") // When you give a default value
                                                                       // for a paramenter in function ,
                                                                       // the default parameter should
                                                                       // be at the end.
        {
            for (int i = 0; i < Count; i++)
                Console.Write(Pattern);
        }
        public static void Swap(ref int Number01, ref int Number02) // Passsing a Value type By Passing By Reference
        {
            int Temp = Number01;
            Number01 = Number02;
            Number02 = Temp;
            Console.WriteLine($"Inside Swap Function : Number01 = {Number01} , And Numbwr02 = {Number02}");
        }
        public static void Swap(int Number01, int Number02) // Passing a Value type By Passing By Value
        {
            int Temp = Number01;
            Number01 = Number02;
            Number02 = Temp;
            Console.WriteLine($"Inside Swap Function : Number01 = {Number01} , And Numbwr02 = {Number02}");
        }
        public static int SumOfArray(int[] Arr) // Passing a Reference type Vy Passing By Value
        {
            int sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr?.Length; i++)
                sum += Arr[i];
            return sum;
        }
        public static int SumOfArray(ref int[] Arr) // Passing a Reference type Vy Passing By Reference
        {
            int sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr?.Length; i++)
                sum += Arr[i];
            return sum;
        }
        public static void SumAndMultiplay(int Number01, int Number02, out int Sum, out int Multiplay)
        {
            Sum = Number01 + Number02;
            Multiplay = Number01 * Number02;
        }
        public static int SumArr(params int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr?.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
    }
}
