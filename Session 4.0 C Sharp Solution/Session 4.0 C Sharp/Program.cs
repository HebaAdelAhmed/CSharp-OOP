using System;

namespace Session_4._0_C_Sharp
{
    [Flags] //Data Anotation
    enum Premesion:byte
    {
        Delete = 1 , Execute = 2, Read = 4 , Write = 8 
    }

    enum Grades
    {
        A,B,C,D, E, F
    }
    enum Gender
    {
        Male,
        Female,
    }

    internal class Program
    {

        //public static void Print(int Count , String Pattern) { 
        //    for (int i = 0; i < Count; i++)
        //    {
        //        Console.Write($"{Pattern}");
        //    }
        //}
        //Passing by value
        //public static void Swap(int X , int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        
        //Passing by reference
        //public static void Swap(ref int X,ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}

        //public static int SumArr(int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0;i < Arr?.Length;i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}

        //public static int SumArr(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr?.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}

        //public static void SumMult(int Num1 , int Num2 , out int Sum , out int Mult)
        //{
        //    Sum = Num1 + Num2;
        //    Mult = Num1 * Num2;
        //}

        public static int Sum(params int[] Arr) {
            int Sum = 0;
            for (int i = 0; i < Arr?.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        static void Main(string[] args)
        {

            //Grades grades = Grades.A;
            //if(grades == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}else
            //    Console.WriteLine(":(");



            //Print(5 , "@"); // Passing parameters using order.
            //Print(Pattern:"A" , Count:10); // Passing parameters using name.
            //int A = 5;
            //int B = 20;  
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Console.WriteLine("After Swap:");
            //Swap(A, B); -> Value
            //Swap(ref A,ref B); // -> Refrence
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //int[] Arr = new int[] { 10,20,50,30,40,100};
            ////Console.WriteLine(SumArr(Arr));
            //Console.WriteLine(SumArr(ref Arr));
            //Console.WriteLine(Arr[0]);

            //int X= 5;
            //int Y = 4;
            //int SResult, MResult;
            //SumMult(Num1: X , Num2: Y , Sum: out SResult , Mult: out MResult);
            //Console.WriteLine($"Sum = {SResult}");
            //Console.WriteLine($"Multiplication = {MResult}");

            //int[] Arr = { 1, 2, 3, 4, 5 };
            //int s = Sum(Arr);
            //s = Sum(1,5,5,5);

            //Console.WriteLine(s);

            Premesion MyP = (Premesion) 3;
            Console.WriteLine(MyP);
        }
    }
}
