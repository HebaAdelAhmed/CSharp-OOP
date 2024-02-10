using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Session_3._0_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loops
            // 32 statements [32 step]
            //for(int i = 1; i <= 10; i++)
            //    Console.WriteLine(i);

            //int[] Numbers = {1 , 2 , 3, 4};
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    //Console.WriteLine(Numbers[i]);
            //    Numbers[i] += 1;
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int Number;
            //bool Flag;
            //do {
            //    Console.WriteLine("Enter an even number: ");
            //    //Number = int.Parse(Console.ReadLine());

            //    Flag = int.TryParse(Console.ReadLine() , out Number);

            //} while (Number % 2 != 0 || !Flag);

            //while (Database.IsConnected)
            //{
            //    //Code
            //} 
            #endregion

            #region Strings

            // String is a referince type, but is worked as a value type.

            //string Name1;
            //Declure for reference from type string,
            //refaring to defult value of reference type = Null

            //Name1 = new string("Heba");
            //Name1 = "Heba";

            //string Message = "Hello";
            //Console.WriteLine(Message.GetHashCode());
            //Message = "Mohammed";
            //// Create new object with a new different identity
            //Console.WriteLine(Message.GetHashCode());
            //Message += " Moataz";
            //Console.WriteLine(Message.GetHashCode());

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hello");
            //Console.WriteLine(stringBuilder.GetHashCode());
            //Console.WriteLine("After Change: ");
            //stringBuilder.Append(" Mohammed Moataz");
            //Console.WriteLine(stringBuilder.GetHashCode());

            #endregion

            #region Array

            //int[] Numbers;
            ////Declare for reference from type array of int
            ////refaring to default value of reference type = Null
            ////zero byte have been allocated at heap
            ////, 4 byte allocated in stack for reference

            //Numbers = new int[3]; // Allocate 3 * 4 bytes at heap,
            //                      // Initialized with default value of int = 0
            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //int[] Numbers2 = new int[3] { 1,5,7 };
            //int[] Numbers3 = new int[] { 1, 5, 7 };
            //int[] Numbers4 = { 1, 5, 7 };

            //Console.WriteLine($"The size of array : {Numbers.Length} , The number of dimension is : {Numbers.Rank}");

            #endregion

            #region Deep Copy and Sallow copy

            //int[] Arr01 = { 1, 2, 3 };

            //int[] Arr02 = { 4, 5, 6 };

            //int[] Arr03 = { 4, 5, 6 };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //// Deep Copy.
            //Arr02 = Arr01;

            //Console.WriteLine("After Change 'Deep Copy':");
            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine(Arr01.GetHashCode());
            //Arr01[1] = 9;
            //Console.WriteLine(Arr01[1]);
            //Console.WriteLine(Arr02[1]);

            //Arr03 = (int[])Arr01.Clone();
            //// Clone will generate new array with new and different identity ,
            //// but with the [Object state] same data of Arr01.
            //// Shallow Copy 

            #endregion

            #region Two Dimension Array

            #region Rectanglar Array

            //int[,] Marks = new int[3 , 5];
            //bool Flag;

            //Console.WriteLine($"The Size of Array = {Marks.Length} , The number of dimension is {Marks.Rank}");

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Marks.GetLength(1); /*j++*/)
            //    {
            //        Console.Write($"Enter Mark of Subject {j+1} for Student number {i+1} : ");
            //        //Marks[i, j] = int.Parse(Console.ReadLine());
            //        Flag = int.TryParse(Console.ReadLine() , out Marks[i, j]);
            //        if (Flag)
            //            j++;
            //    }
            //}

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine(Marks[i,j]);
            //    }
            //}

            //// N^2

            //Console.Clear();

            //for(int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i / Marks.GetLength(1) , i % Marks.GetLength(1)]);
            //}
            //// N


            #region Array Functions

            //int[] Numbers = { 10,50,30,40,8,2,9 };

            ////Array.Sort(Numbers);
            //Array.Reverse(Numbers);

            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine(Numbers[i]);
            ////}
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #endregion

            #region Judged Array

            // One dimension array of arrays.

            //int[][] Numbers = new int[2][];

            //Numbers[0] = new int[4] { 1,5,8,9};
            //Numbers[1] = new int[2] { 5, 8 };

            #endregion

            #endregion

            #region Boxing vs. Unboxing

            //Object O = new Object();
            //// Boxing
            //O = "Mohammed Moataz";
            //O = 2;
            //O = 'A';
            //O = new DateTime();

            //int x = 10;
            //Object O1 = x;
            //// Casting from int [value type] to object [reference type] implicity.
            //// Safe Casting.


            //Object O2 = 20;
            //int Y = (int) O2;
            //// Unsafe casting
            //// Casting from object [reference type] to int [value type]



            #endregion

            #region Nullable
            //int? M = 10;
            //M = null;
            //int L = M ?? 0;
            ////if (M.HasValue)
            ////    L = M.Value;
            ////else L = 0;
            ///
            //double X = default; // 0
            //Console.WriteLine(X);

            //int[] Arr = default; // Null
            //for (int i = 0; (Arr != null) && (i < Arr.Length) ; i++) {
            //    Console.WriteLine(Arr[i]);
            //}

            //for (int i = 0; i < Arr?.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //} 
            #endregion

            //// 32 statement [steps]
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // for loop for edit in the array
            // foreach for loop in array
            //int[] arr = { 1, 2, 3 };
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    arr[i] += 1;
            //}
            //foreach(int Number in arr)
            //{
            //    Console.WriteLine(Number);
            //}
            
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.Write("Please enter an even number: ");
            //    //Number = int.Parse(Console.ReadLine());
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}while(!Flag || Number % 2 != 0);

            //string Name1 = "Ahmed";
            //string Name2 = "Aya";
            //Name1 = Name2;

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb.GetHashCode());
            sb.Append(" Hebba");
            Console.WriteLine(sb.GetHashCode());
            Console.WriteLine(sb.ToString());   

        }
    }
}
