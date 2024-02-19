using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static RouteCSharpLINQ.ListGenerators;

namespace RouteCSharpLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable : [var , dynamic]
            //var Data01 = "Ahmed";
            //// Compiler Will Detect The Type Of The Variable Based On Its Initaial Value at Compilation Time
            //// Variable Declared With Keyword ["var"] Must Be Initialized With Value
            //// Can't Be Initialized With Null Value 
            //// After Initialization , U Can't Change Its datatype

            //dynamic Data02 = "Heba";
            //// CLR Will Detect The Type Of The Variable Based On Its Last Assigned Value at Runtime
            //// Variable Declared With Keyword ["dynamic"] Not Must Be Initialized With Value
            //// Can Be Initialized With Null Value 
            //// After Initialization , U Can Change Its datatype
            #endregion

            #region Extension Method
            //int X = 123456;
            ////int Y = IntExtention.Reverse(X);
            //int Y = X.Reverse();
            //Console.WriteLine(Y);
            #endregion

            #region Anonymous Type
            //var Emp01 = new { Id = 510, Name = "Heba", Salary = 10000 };
            //// Object From Anonymous Type Is an Immutable
            //Console.WriteLine(Emp01.Id);
            //Console.WriteLine(Emp01); 
            #endregion

            #region LINQ Intro
            /// LINQ
            /// LINQ : IS Stand For Language-Integrated Quary
            /// LINQ : +40 Extention Methods Named As [Quary Operators] Existed At [Enumerable Class]
            ///       => Extention Methods To Classes That Implement The Build In Interface Called IEnumerable
            /// LINQ Operators Are Categorized Into 13 Categories 
            /// Use LINQ Functions Against Data (Any Sequence) Regardless Data Store
            /// Sequence : Any Class Implement IEnumerable (Like List , Array , Dictionary ....)
            /// 1. Local Sequence  : L2Object , L2XML
            /// 2. Remote Sequence : L2EF


            //List<int> Numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OodNumbers = Numbers.Where(N => N % 2 == 1);
            //foreach (var number in OodNumbers)
            //    Console.WriteLine(number);
            #endregion

            #region LINQ Syntex

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1. Fluent Syntax:
            /// 1.1 Calling LINQ Operators As "Static Methods" Trought Enumerable Class

            //var OodNumbers = Enumerable.Where(Numbers, (N) => N % 2 == 1);
            //foreach (var ood in OodNumbers)
            //    Console.WriteLine(ood);

            /// 1.2 Calling LINQ Operators As Extention Methods

            //var OodNumbers = Numbers.Where((N) => N % 2 == 1); // Extention Method For Numbers [List]
            //foreach (var ood in OodNumbers)
            //    Console.WriteLine(ood);

            // 2. Query Syntax : [Quary Expression] -> Like SQL Server Style
            /// Start With From , Introducing Range Variable (N) : Reperesents Each Element At Sequence
            /// End With Select Or Group By

            //var OodNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;



            #endregion

            #region LINQ Execution

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /// Differd Execution : Lastest Update Of Data -> 10 Categories
            //var OddNumbers = Numbers.Where((N) => N % 2 == 1); // 1 , 3 , 5 , 7 , 9 , 11 , 13 , 15


            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach(int odd in OddNumbers) 
            //    Console.WriteLine(odd);

            /// Immediate Execution : [Casting , Element , Aggregate] -> 3 Categories

            //var OddNumbers = Numbers.Where((N) => N % 2 == 1).ToList(); // 1 , 3 , 5 , 7 , 9

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (int odd in OddNumbers)
            //    Console.WriteLine(odd);

            #endregion

            #region Filteration (Restraction) Operator -> Where

            var Result = ProductList.Where((P) => P.UnitsInStock == 0); // Fluent Syntax , C#
            
            Result = from P in ProductList
                         where P.UnitsInStock == 0
                         select P; // Query Syntax , Quary Experssion
            
            //foreach (var Product in Result)
            //    Console.WriteLine(Product);
            //Console.WriteLine("------------------------");
            
            Result = ProductList.Where((P) => P.UnitsInStock == 0 && P.Category == "Meat/Poultry");

            Result = from P in ProductList
                     where P.UnitsInStock == 0 && P.Category == "Meat/Poultry"
                     select P;

            //foreach (var Product in Result)
            //    Console.WriteLine(Product);
            //Console.WriteLine("------------------------");

            // Indexed Where :
            // Valid Only With a Fluent Exeprssion

            #endregion

            #region Part 09 Transformation Operators - Select, SelectMany

            var Result02 = ProductList.Select(P => P.ProductName);

            Result02 = from P in ProductList
                       select P.ProductName;

            //foreach (var item in Result02) 
            //    Console.WriteLine(item);

            var Result03 = CustomerList.SelectMany(C => C.Orders);

            Result03 = from C in CustomerList
                       from O in C.Orders
                       select O;

            //foreach (var item in Result03)
            //    Console.WriteLine(item);

            var Result04 = ProductList.Select(P => new { Id = P.ProductID , Name = P.ProductName });

            Result04 = from P in ProductList
                       select new { Id = P.ProductID, Name = P.ProductName };

            var DiscountProduct = ProductList.Where((P) => P.UnitsInStock == 0).Select(P => new { P.ProductID , P.ProductName , Price = P.UnitPrice * .5M });

            DiscountProduct = from P in ProductList
                              where P.UnitsInStock == 0
                              select new 
                              {
                                  P.ProductID,
                                  P.ProductName,
                                  Price = P.UnitPrice * .5M
                              };

            //foreach (var item in DiscountProduct)
            //    Console.WriteLine(item);

            var Result05 = ProductList.Select((P, i) => new { Index = i, Name = P.ProductName });

            //foreach (var item in Result05)
            //    Console.WriteLine(item);

            #endregion

            #region Ordering Operator

            var Result06 = ProductList.OrderBy(P => P.UnitsInStock).ThenBy(P => P.UnitPrice);

            Result06 = from P in ProductList
                       orderby P.UnitsInStock, P.UnitPrice
                       select P;

            var Result07 = ProductList.Where(P => P.UnitsInStock == 0).Reverse();

            //foreach (var item in Result07)
            //    Console.WriteLine(item);

            #endregion

            #region Element Operator - Immediate Execution

            var Result08 = ProductList.FirstOrDefault();
            //Console.WriteLine(Result08?.ProductName ?? "NA");
            Result08 = ProductList.LastOrDefault();
            //Console.WriteLine(Result08?.ProductName ?? "NA");
            Result08 = ProductList.ElementAtOrDefault(0);
            //Console.WriteLine(Result08?.ProductName ?? "NA");

            // Hypried Syntax : (Quary Syntax).Fluent Syntax
            var Result09 = (from P in ProductList
                           where P.UnitsInStock > 2
                           select new { P.ProductID , P.ProductName , P.UnitsInStock , P.UnitPrice}
                           ).FirstOrDefault();
            //Console.WriteLine(Result09);

            #endregion

            #region Aggregate Operators - Immediate Execution [COUNT , SUM , AVERAGE , MIN , MAX]

            var Result10 = ProductList.Count(P => P.UnitsInStock > 5);

            var Result11 = ProductList.Max();
            Result11 = ProductList.Min();
            
            var Result12 = ProductList.Max(P => P.UnitPrice);
            Result12 = ProductList.Min(P => P.UnitPrice);

            var Result13 = (from P in ProductList 
                           where P.ProductName.Length == ProductList.Min(P => P.ProductName.Length)
                           select P).LastOrDefault();

            Console.WriteLine(Result13?.ProductName ?? "NA");

            var Result14 = ProductList.Sum(P => P.UnitPrice);
            Result14 = ProductList.Average(P => P.UnitPrice);

            Console.WriteLine(Result14);

            #endregion

            #region Casting Operators - Immediate Execution

            List<Product> products = ProductList.Where(P => P.UnitsInStock > 10).ToList();

            #endregion

            #region Generation Operators
            /// Only The Way To Call Them Is As "Static Methods" Trought Enumerable Class

            var Result15 = Enumerable.Range(0, 100); // 0..99
            Result15 = Enumerable.Repeat(2, 100);
            
            var Result16 = Enumerable.Empty<Product>(); // == Product[] Result16 = new Product[0];


            #endregion

            #region Set Operators - Union Family

            var Seq01 = Enumerable.Range(0, 100); // 0..99
            var Seq02 = Enumerable.Range(50, 100); // 50..149
            var Result17 = Seq01.Union(Seq02); // 0..149 // Without Dublicates
            
            Result17 = Seq02.Concat(Seq01); // 0..99..50..149 // With Dublicate
            Result17 = Result17.Distinct(); // For Remove Dublicates
            Result17 = Seq01.Except(Seq02); // 0..49 // Things That In The First 'Seq01' and Not in The Secund 'Seq02'
            Result17 = Seq01.Intersect(Seq02); // 50..99 // Things That In The Seq01 and Seq02 In The Same Time

            //foreach (var item in Result17)
            //    Console.WriteLine(item);

            #endregion

            #region Quantifier Operators - Return Boolean

            Console.WriteLine(
                ProductList.Any() // Return true If Sequence Contain At Least 1 Element
                                  // Return false IF Sequence Is Empty
                );
            Console.WriteLine(
                ProductList.Any(P => P.UnitsInStock == 0) // Return true If At Least 1 Element Match Condation 
                                                          // Return false IF Not
                );
            Console.WriteLine(
                ProductList.All(P => P.UnitsInStock == 0) // Return true If All Element In The Sequence Match Condation 
                                                          // Return false IF Not
                );
            Console.WriteLine(
               Seq02.SequenceEqual(Seq01) // Return true If Seq01 == Seq02  
                                          // Return false IF Not
                );
            #endregion

            #region Grouping Operator

            var Categories = from P in ProductList
                             group P by P.Category;

            Categories = ProductList.GroupBy(P => P.Category);
            //foreach ( var category in Categories )
            //    Console.WriteLine(category.Key);

            //foreach ( var category in Categories )
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.Write("----------------  ");
            //        Console.WriteLine(product.ProductName);
            //    }
            //}
            Console.WriteLine("---------------------------------------------");
            var Result18 = from P in ProductList
                           where P.UnitsInStock != 0
                           group P by P.Category
                           into category 
                           where category.Count() > 5
                           select new { Category = category.Key , Count = category.Count() };

            //Result18 = ProductList
            //    .Where(P => P.UnitsInStock != 0)
            //    .GroupBy(P => P.Category)
            //    .Where(Cat => Cat.Count() > 5)
            //    .Select(new { Category = Cat.Key , Count = Cat.Count() }) ;

            //foreach (var category in Result18)
            //{
            //    Console.WriteLine(category);

            //}
            #endregion

            #region Partitioning Operators : Take , TakeLast , Skip , SkipLast , TakeWhile , SkipWhile

            var Result19 = ProductList.Where(P => P.UnitsInStock == 0).Take(2);
            Result19 = ProductList.Where(P => P.UnitsInStock == 0).TakeLast(2);
            Result19 = ProductList.Where(P => P.UnitsInStock == 0).Skip(2);

            foreach (var Product in Result19)
                Console.WriteLine(Product);

            #endregion
        }
    }
}
