using System;
using System.Collections.Generic;
using System.Linq;

namespace RouteCSharpDelegate
{
    /// Delegate : C# Language Feature
    /// Has Two Usages :
    /// 1. Pointer For a Function OR More
    /// 2. Event Driven Programming 
    /// 
    /// Step 0 : Delegate Decleration -> Same Signature Of Function
    /// New Class (Delegate) , Any Reference From This Delegate Can Refer To Function Or More (Pointer For Function Or More)
    /// This Function May Be Class Function (Static Method) OR Object Function (Non-Static Method).
    /// But Must Be With The Same Signature : int (string)
    /// Regardless Function Name Or Its Access Modifire
    /// 
    /// Step 1 : Declare Reference From Delegate
    /// 
    /// Step 2 : Initialize Reference : Pointer To Function
    /// 
    /// Step 3 : Use Delegate Reference (Call Function)



    //public delegate bool CheckNumber<in T>(T Number); // U Can Use Predicate Instade Of This 
    // Predicate : Is A Delegate That Refer To a Function Take One Parameter , And Its Return Type Is BOOLEAN

    internal class Program
    {

        public static List<T> GetNumbersBasedOnPassedFunction<T>(List<T> Numbers, Predicate<T> checkNumber)
        {
            List<T> Result = new List<T>();
            if (checkNumber != null)
                for (int i = 0; i < Numbers?.Count; i++)
                {
                    if (checkNumber?.Invoke(Numbers[i]) == true)
                        //if (Numbers[i] % 2 == 1)
                        Result.Add(Numbers[i]);
                }
            return Result;
        }


        static void Main(string[] args)
        {
            #region Delegate Example 01
            //int[] Arr = { 1, 2, 3, 10, 9, 6, 3, 2, 5, 1 };
            //Func<int, int, bool> Func01 = CompareFunctions.CompGreater;
            //SortingAlgorithms<int>.BubbleSort(Arr, Func01);
            //foreach (int i in Arr)
            //    Console.WriteLine(i);

            //string[] Names = { "Heba Adel", "Ali AbdElKarim", "Ahmed Ali", "Mohammed Moataz", "Amen Mohammed", "Aman Mohammed", "Farah Mohammed", "Marah Mohammed", "Thanaa Ahmed", "Mariam AbdElMajed" };
            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunctions.CompLengthAscending);
            //foreach (string name in Names)
            //    Console.WriteLine(name); 
            #endregion

            #region Delegate Example 02
            //List<int> Numbers = Enumerable.Range(0, 100).ToList(); // 0 .. 99
            //Predicate<int> checkNumber = ConditionalFunctions.CheckEvenNumber;
            //List<int> Result = GetNumbersBasedOnPassedFunction(Numbers, checkNumber);
            //foreach (int item in Result)
            //    Console.Write($"{item}  ");

            //List<string> Names = new List<string>() { "Heba", "Ali", "Ahmed", "Mohammed", "Amen", "Aman", "Farah", "Marah", "Thanaa", "Mariam" };
            //Predicate<string> predicate01 = ConditionalFunctions.CheckIfStringLengthMoreThan4;
            //List<string> NamesWithLengthMoreThan4 = GetNumbersBasedOnPassedFunction(Names, predicate01);
            //foreach (string name in NamesWithLengthMoreThan4)
            //    Console.WriteLine(name);
            //List<string> NamesStartingWithA = GetNumbersBasedOnPassedFunction(Names, ConditionalFunctions.CheckStringStartingWithA);
            //foreach (string name in NamesStartingWithA)
            //    Console.WriteLine(name); 
            #endregion

            #region Anonymous and Lambada Function
            ////Anonymous Function : C# 2.0 Feture
            //Predicate<int> predicate02 = delegate(int num)
            //{
            //    return num > 5;
            //};
            //Func<int, string> func02 = delegate(int num)
            //{
            //    return $"Number Is : {num}";
            //};
            //Action<string> action01 = delegate(string name)
            //{
            //    Console.WriteLine($"Hello, {name}");
            //};

            //// Lambada Experession: C# 3.0 Feature
            //// => Called as FatArrow , Read As GoesTo

            //Predicate<int> predicate03 = (num) =>
            //{
            //    return num > 5;
            //};
            //Func<int, string> func03 = (num) =>
            //{
            //    return $"Number Is : {num}";
            //};
            //Action<string> action03 = (name) =>
            //{
            //    Console.WriteLine($"Hello, {name}");
            //}; 
            #endregion

            #region Some List_Methods That Take Functions As Parameters
            //List<int> Numbers = new List<int>() { 45, 54, 8, 89, 3, 6, 4, 75, 14, 45, 44, 35, 33, 25, 10 };
            //Numbers.RemoveAll( (num) =>  num % 2 == 1); 
            //foreach (int i in Numbers)
            //{
            //    Console.Write($"{i}     ");
            //}
            //Console.WriteLine();
            //List<int> NumbersThatDivideByEight = Numbers.FindAll((num) => num % 8 == 0);
            //Console.WriteLine("--------------------");
            //foreach (int i in NumbersThatDivideByEight)
            //{
            //    Console.Write($"{i}     ");
            //} 
            #endregion


        }
    }

    internal class ConditionalFunctions
    {
        public static void Test03(string name) { Console.WriteLine($"Hello, {name}"); }
        public static string Test02(int num) { return $"Number Is : {num}"; }
        public static bool Test01(int num) { return num > 5; }
        public static bool CheckOodNumber(int num) { return num % 2 == 1; }
        public static bool CheckEvenNumber(int num) { return num % 2 == 0; }
        public static bool CheckDivisionbySevenNumber(int num) { return num % 7 == 0; }
        public static bool CheckIfStringLengthMoreThan4(string s) { return ((s?.Length??0) > 4); }
        public static bool CheckStringStartingWithA(string s) { return s.StartsWith('A'); }
    }
}
