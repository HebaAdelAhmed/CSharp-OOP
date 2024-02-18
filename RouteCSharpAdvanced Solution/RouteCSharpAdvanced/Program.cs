using System;
using System.Collections;
using System.Collections.Generic;

namespace RouteCSharpAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int X = 5;
            //int Y = 10;
            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");
            //Helper.Swap(ref X, ref Y);
            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");

            //// In Generic Method Case (Not Generic Class Or Generic Interface Or Generic Struct)
            //// Compiler Can Detect The Type Of T From The Input Parameter Of Generic Method

            //Console.WriteLine("------------------");

            //Point P01 = new Point(10, 15);
            //Point P02 = new Point(13, 16);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");
            //Helper.Swap(ref P01, ref P02);
            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            //Console.WriteLine("------------------");

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 10, 9, 12, 12, 13, 10 };
            //Console.WriteLine(Helper.SearchInArray(Numbers, 10));

            //Console.WriteLine("------------------");

            //Employee Emp01 = new Employee() { Id = 20, Name = "Heba", Salary = 10000 };
            //Employee Emp02 = new Employee() { Id = 10, Name = "Mohammed", Salary = 12000 };
            //Employee Emp03 = new Employee() { Id = 105, Name = "Mohammed", Salary = 1000 };
            //Employee Emp04 = new Employee() { Id = 104, Name = "Mohammed", Salary = 152000 };

            //Employee[] employees = { Emp01, Emp02, Emp03, Emp04 };

            ////if (Emp01 == employee[1])
            ////    Console.WriteLine("equal");

            //Console.WriteLine(Helper<Employee>.SearchInArray(employees, Emp02));
            //Helper<Employee>.BubbleSort(employees);
            //for (int i = 0; i < employees?.Length; i++) 
            //{
            //    Console.WriteLine(employees[i]);
            //}

            //Point[] points = 
            //{
            //    new Point(10 , 5),
            //    new Point(2 , 7),
            //    new Point(13 , 10),
            //    new Point(46 , 5),
            //    new Point(5 , 4),
            //};
            //Helper<Point>.BubbleSort(points);
            //foreach (Point point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //ArrayList arrayList = new ArrayList(10); // Count = 0 , Capacity = 10
            // Capacity : Is The Size Of Array List
            // Count : Is How Much It Take Right Now 
            //ArrayList arrayList = new ArrayList(5);
            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");
            //arrayList.Add( 1 );
            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");
            //arrayList.Add(1);
            //arrayList.Add(1);
            //arrayList.Add(1);
            //arrayList.Add(1);

            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");
            //arrayList.Add(1);

            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");
            //arrayList.TrimToSize();
            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");

            /// Generic Collections 
            /// 1. Listing : 1.1 List
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");

            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(4);
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");
            //Numbers.Add(5);
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");
            //Numbers.TrimExcess();
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");
            //// Use Indexer

            //Numbers[0] = 0; // Use Indexer For Update (Set)
            //Console.WriteLine(Numbers[0]); // Use Indexer (Get)

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //LinkedList<string> list = new LinkedList<string>();
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Heba");
            //queue.Enqueue("Mohammed");
            //Console.WriteLine(queue.Dequeue()); // Heba
            //Stack<string> stack = new Stack<string>();
            //stack.Push("Heba");
            //stack.Push("Mohammed");
            //Console.WriteLine(stack.Pop()); // Mohammed

            //Dictionary<string , int> PhoneBook = new Dictionary<string , int>();
            //PhoneBook.Add("Heba" , 01);
            //PhoneBook.Add("Mohammed", 020);
            //PhoneBook["Heba"] = 10; // Using Indexer For Update (SET)
            //Console.WriteLine(PhoneBook["Mohammed"]); // Using Indexer For Retrive (GET)
            //PhoneBook["Amen"] = 30; // Using Indexer For Adding
            //Console.WriteLine(PhoneBook.Count);
            //foreach (var phone in PhoneBook)
            //{
            //    Console.WriteLine(phone);
            //}
            //foreach (var phone in PhoneBook)
            //{
            //    Console.WriteLine(phone.Key);
            //}
            //Console.WriteLine(PhoneBook.Count);
            //////PhoneBook.Add("Heba", 01); // Unsafe Code
            //if (!PhoneBook.ContainsKey("Heba"))
            //    PhoneBook.Add("Heba", 50);
            //else
            //    PhoneBook["Heba"] = 50;
            //Console.WriteLine(PhoneBook.Count);

            //if(!PhoneBook.TryAdd("Heba" , 36))
            //    PhoneBook["Heba"] = 36;

            ////Console.WriteLine(PhoneBook["Pola"]); // Unsafe Code
            //int Number;
            //Console.WriteLine(PhoneBook.TryGetValue("Pola" , out Number));
            //Console.WriteLine(Number);

            //HashSet<int> Set = new HashSet<int>(); // Unique
            //Set.Add(1);
            //Set.Add(2);
            //Set.Add(1);
            //foreach (int i in Set)
            //{
            //    Console.WriteLine(i);
            //}

            /// Delegate : C# Language Feature
            /// Has Two Usages :
            /// 1. Pointer For a Function OR More
            /// 2. Event Driven Programming

            /// Step 01: Declare Reference From Delegate
            StringFuncDelegate stringFunc;
            /// Step 02: Initialize Delegate (Reference) -> By Making It Pointer For Function
            //stringFunc = new StringFuncDelegate(StringFunction.GetCountOfUpperChars);
            stringFunc = StringFunction.GetCountOfUpperChars;
            stringFunc += StringFunction.GetCountOfLowerChars;
            /// Step 03: Use Delegate Reference (Call Function)
            int Result = stringFunc.Invoke("Ahmed Ali");
            Console.WriteLine(Result);


        }
    }

    /// <summary>
    /// Step 00: Delegate Declaration
    /// </summary>
    public delegate int StringFuncDelegate(string s);
    /// <summary>
    /// New Delegate (Class) : Any Reference From This Delegate Can Refer to Function Or More
    /// This Function May Be (Static Function , Non-Static Function)
    /// This Function Must Have The Same Signanture Of The Delegate = EX:-> int (string)
    /// Regardless The Function Name or Its Access Modifire
    /// </summary>
    class StringFunction
    {
        public static int GetCountOfUpperChars(string Name)
        {
            Console.WriteLine("Execute GetCountOfUpperChars");
            int Counter = 0;
            for (int i = 0; i < Name?.Length; i++) 
            {
                if (Char.IsUpper(Name[i]) )
                    Counter++;
            }
            return Counter;
        }
        public static int GetCountOfLowerChars(string Name)
        {
            Console.WriteLine("Execute GetCountOfLowerChars");
            int Counter = 0;
            for (int i = 0; i < Name?.Length; i++)
            {
                if (Char.IsLower(Name[i]))
                    Counter++;
            }
            return Counter;
        }
    }
}
