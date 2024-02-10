using System;

namespace ArraySession
{

    class Hambozo
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region One Dimainsional Array:

            //int[] Numbers1;
            ///// declare for reference from type array of int.
            ///// refairong to default value of reference type = null.
            ///// Zero byte have allocated in heap.

            //Numbers1 = new int[3]; // Allocate 4*3 Bytes in heap. and initialized with a default value of int = 0
            //Console.WriteLine(Numbers1[0]);
            //Console.WriteLine(Numbers1[1]);
            //Console.WriteLine(Numbers1[2]);
            //Console.WriteLine(Numbers1[3]); // invaled 

            //int[] Numbers2 = new int[3] { 1 ,2, 3 };
            //int[] Numbers3 = new int[] { 1, 2, 3 };
            //int[] Numbers4 = { 1, 2, 3 };

            //Console.WriteLine($"The Size of ARRAY Number4 = {Numbers4.Length} The Number of Dimension is {Numbers4.Rank}");


            #endregion

            #region DEEP COPY AND SHALLOW COPY

            ////DEEP COPY
            //Console.WriteLine("DEEP COPY EX:");
            //int[] Arr01 = { 1, 2, 3, 4, 5 };
            //int[] Arr02 = { 6, 7, 8, 9, 10 };

            //Console.WriteLine($"Arr01 GetHashCode() : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 GetHashCode() : {Arr02.GetHashCode()}");
            //// GetHashCode() : to Get unique Id based on adderse of reference.

            //Arr02 = Arr01;
            //// This Object { 1, 2, 3, 4, 5 } has to Reference (اسمين دلع)
            //// This Object { 6, 7, 8, 9, 10 } is an unreachable object.
            //// DEEP COPY : Copy for data and address of reference
            //Console.WriteLine("AFTRE ASSIGN: ");
            //Console.WriteLine($"Arr01 GetHashCode() After Assign Arr02 = Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 GetHashCode() After Assign Arr02 = Arr01 : {Arr02.GetHashCode()}");

            //Arr01[0] = 7; // Then Arr01 = { 7, 2, 3, 4, 5 } and Arr02 = { 7, 2, 3, 4, 5 }
            //Console.WriteLine($"After edit Arr01[0] to {Arr01[0]} Try to print Arr02[0] : {Arr02[0]}");

            //Console.WriteLine("SHALLOW COPY EX:");
            //int[] Arr03 = { 1, 2, 3, 4, 5 };
            //int[] Arr04 = { 6, 7, 8, 9, 10 };
            //// SHALLOW COPY : Copy data but with a different identity .. Will create a new object.
            //Console.WriteLine($"Arr03 GetHashCode() : {Arr03.GetHashCode()}");
            //Console.WriteLine($"Arr04 GetHashCode() : {Arr04.GetHashCode()}");

            //Arr04 = (int[])Arr03.Clone();
            //Console.WriteLine("After Shallow Copy: After using Clone()");
            //Console.WriteLine($"Arr03 GetHashCode() : {Arr03.GetHashCode()}");
            //Console.WriteLine($"Arr04 GetHashCode() : {Arr04.GetHashCode()}");
            //Arr03[0] = 12;
            //Console.WriteLine($"In SHALLOW COPY Arr03[0] = {Arr03[0]} But Arr04[0] = {Arr04[0]}");

            #endregion

            #region Two Dimensional Array:

            #region Rectanglar Array
            ////int[R, C] -> R: Number of Rows , C: Number of Columns
            //int[,] Marks01 = new int[3, 5];
            //int[,] Marks02 = new int[3, 5] { // 3 Students (3 Rows), 5 Subjects (5 Columns)
            //    {1,2,3,4,5 },
            //    {6,7,8,9,10 },
            //    {11,12,13,14,15 }
            //};

            //Console.WriteLine($"The Size Of Marks02 Array = {Marks02.Length} , and Number of Array Dimension in array = {Marks02.Rank}");

            //bool Flag;
            //for (int i = 0; i < Marks02.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student Number {i+1}");
            //    for (int j = 0; j < Marks02.GetLength(1);)
            //    {
            //        Console.Write($"Enter Subject Number {j+1} Mark: ");
            //        Flag = int.TryParse(Console.ReadLine(), out Marks02[i, j]);
            //        if (Flag && Marks02[i, j] >= 0)
            //        {
            //            j++;
            //        }
            //    }
            //}

            //Console.Clear();

            //Console.WriteLine("=================READ ARRAY=================");
            //for (int i = 0; i < Marks02.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student Number {i+1}");
            //    for (int j = 0; j < Marks02.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter Subject Number {j+1} Mark is : {Marks02[i, j]}");
            //    }
            //    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            //}

            //// Time Complixty is N^2

            //Console.Clear();

            ///// Number of Current Row     -> i / Number of Columns 
            ///// Number of Current Column  -> i % Number of Columns
            ///// To Get Number Of Rows in Array -> NameOfArray.GetLength(0);
            ///// To Get Number Of Columns in Array -> NameOfArray.GetLength(1);


            //for (int i = 0; i < Marks02.Length; i++)
            //    Console.WriteLine(Marks02[i / Marks02.GetLength(1), i % Marks02.GetLength(1)]);

            //// Time Complixty is N


            #endregion

            #region Judged Array

            /// Judged Array : One Dimensional Array each index in it is a reference of an other
            /// Judged Array : Is An Array Of Array
            /// int [] []
            //int[][] Numbers = new int[3][];
            //Numbers[0] = new int[] { 10 , 3 , 2};
            //Numbers[1] = new int[] { 5, 7 };
            //Numbers[2] = new int[] { 1 };

            //Console.WriteLine($"The Number Of Array In Of Numbers Array As A JUDGED ARRAY : {Numbers.Length} , The Prove That JUDGED Array Is A One Dimentional Array Is : {Numbers.Rank}");

            #endregion

            #endregion

            #region Array Function

            //int[] Numbers01 = { 10, 80, 60, 51, 99, 1, 78 };
            //Console.WriteLine("Array:");
            //foreach (int item in Numbers01)
            //    Console.WriteLine(item);
            //Console.WriteLine("=========================");

            //Array.Sort(Numbers01);
            //Console.WriteLine("After Sort Array:");
            //foreach (int item in Numbers01)
            //    Console.WriteLine(item);
            //Console.WriteLine("=========================");

            //Array.Reverse(Numbers01);
            //Console.WriteLine("After Reverse Array:");
            //foreach (int item in Numbers01)
            //    Console.WriteLine(item);
            //Console.WriteLine("=========================");

            //Console.WriteLine(Array.BinarySearch(Numbers01, 10));
            #endregion

            #region Boxing And UnBoxing:

            ///// Boxing && UnBoxing : Casting Between Value Type And Reference Type
            ///// Boxing : Cast From Value Type To -> Reference Type
            ///// UnBoxing : Cast From Reference Type To -> Value Type

            //Object O = new Object();
            //O = "Ahmed";
            //O = 2; // Boxing
            //O = 'A'; // Boxing
            //O = 4.5; // Boxing
            //O = new DateTime(); // Boxing
            //O = new Hambozo();

            //int X = 10;
            //Object O01 = X;
            ///// Casting From int [Value Type] To -> [Object] Reference Type. (Implicitly)
            ///// Boxing
            ///// Safe casting
            ///// Parent = Child
            ///// Animal = Dog

            //Object O02 = 20;
            //int Y = (int) O02;
            ///// Casting From Object [Reference Type] To -> int [Value Type]. (Explicitly)
            ///// Unboxing
            ///// UnSafe Casting
            ///// Child = Parent -> Must be sure (Child = (Child) Parent);
            ///// Dog = Animal -> Dog = (Dog) Animal;


            #endregion

            #region Nullable Types:

            ///// Value type allow null value

            //int X = 20; // X Allow int Value only
            ////X = null; // Invalid

            //int? Y = 30; // Y Allow int value and Null Value.
            //Y = 50;
            //Y = null; // Valid.

            //Y = X; // if you assign an int value to a nullable variable it's Valid  -- Implicit Casting -- Safe

            //int ? L = 77;
            //int K;
            ////K = (int) L; // Explicit Casting -- UnSafe
            
            //// Protective Code
            //if (L != null)
            //    K = (int) L;
            //K = (L != null) ? (int) L : 0;

            //if (L.HasValue)
            //    K = (int) L.Value;
            //else K = 0;

            //K = L ?? 0;


            double X = default;
            Console.WriteLine(X); // 0

            int[] Num01 = default;
            Console.WriteLine(Num01); //null
            for (int i = 0; Num01 != null && i < Num01.Length; i++) // Null Reference Exception
                Console.WriteLine(Num01[i]);

            #region Null Probagation Operator. 
            for (int i = 0; i < Num01?.Length; i++) // Null Reference Exception
                Console.WriteLine(Num01[i]); 

            int? Length01 = Num01?.Length;
            int Length02 = Num01?.Length ?? 0;

            // Employee?.Department?.Name;

            #endregion

            #endregion
        }
    }
}
