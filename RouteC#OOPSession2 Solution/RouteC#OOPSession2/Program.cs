using RouteC_OOPSession2.Operators_Overloading;
using System;
//using System.Runtime.Intrinsics.Arm;
//using RouteC_OOPSession2.Abstracte;
//using RouteC_OOPSession2.Classes;
//using RouteC_OOPSession2.Interfaces;
//using RouteC_OOPSession2.Operators_Overloading;
//using RouteC_OOPSession2.Polymorphism_Overloading;
//using RouteC_OOPSession2.Polymorphism_Override;

namespace RouteC_OOPSession2
{
    internal class Program
    {

        //public static void PrintTenNumbersFromSeries(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}  ");
        //        series.GetNext();
        //    }
        //    Console.WriteLine();
        //    series.Reset();

        //}

        //public static void ProcessEmployee(Employee employee)
        //{
        //    employee.Fun01();
        //    employee.Fun02();
        //}

        //Do not apply Open Close Principle
        //public static void ProcessEmployee(FullTimeEmployee fullTimeEmployee)
        //{
        //    fullTimeEmployee.Fun01();
        //    fullTimeEmployee.Fun02();
        //}

        //public static void ProcessEmployee(PartTimeEmployee partTimeEmployee)
        //{
        //    partTimeEmployee.Fun01();
        //    partTimeEmployee.Fun02();
        //}

        static void Main(string[] args)
        {
            #region Polymorphism : Overloadng
            //Console.WriteLine(Operation.Sum(1, 2)); 
            #endregion

            #region Polymorphism : Overriding
            //TypeA typeA = new TypeA(2);
            ////Console.WriteLine(typeA.A);
            //typeA.A = 11;
            //typeA.Fun01(); // I am Base [Parent]
            //typeA.Fun02(); // TypeA : A = 11
            //TypeB typeB = new TypeB(10 , 20);
            //typeB.Fun01(); // I am Derived [Child]
            //typeB.Fun02(); // TypeB : A = 10 , B = 20 
            #endregion

            /// Binding:
            /// Reference From Parent = Object From Child

            #region Binding Example 01
            //TypeA RefBase = new TypeB(1, 5);
            //RefBase.A = 10;
            ////RefBase.B = 20; // Invaled
            //RefBase.Fun01(); // new -> execute behavior in parent => I am Base [Parent]
            //// Static Binding :-> [Early Binding]
            //// Compiler Will Bind Function Call Based On Reference Type Not Object Type.
            //// At Compilation Time 

            //RefBase.Fun02(); // override -> execute behvior in child => TypeB A: 10 , B: 5
            //                 // Dynamic Binding :-> [Late Binding]
            //                 // CLR Will Bind Function Call Based On Object Type Not Reference Type 
            //                 // At Runtime

            ////RefBase.Fun03(); // Invalid 
            #endregion

            #region Binding Example 02
            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 10;
            ////typeA.B = 20; // Invalid
            ////typeA.C = 30; // Invalid
            //typeA.Fun01(); // I am Base [Parent]  -> Static Binding Method
            //typeA.Fun02(); // TypeC => A = 10 , B = 2 , C = 3  -> Dynamic Binding Method
            ////typeA.Fun03(); // Invalid

            //Console.WriteLine("======================");

            //TypeB typeB = new TypeC(2, 3, 4);
            //typeB.A = 10;
            //typeB.B = 20;
            ////typeB.C = 30; // Invalid
            //typeB.Fun01(); // I am Divider [Child]  -> Static Binding Method 
            //typeB.Fun02(); // TypeC => A = 10 , B = 20 , C = 3  -> Dynaimc Binding Method
            //typeB.Fun03(); // TypeB : A = 10 , B = 20   
            #endregion

            #region Binding Example 03
            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5); 
            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //TypeE typeE = new TypeE(1, 2, 3, 4, 5);

            //// دايما اللي بيتنفذ في الحالة دي اخر
            //// Override
            //// اتعمل بعد ال
            //// Virtual

            //typeA.Fun02(); // TypeC => A = 1 , B = 2 , C = 3
            //typeB.Fun02(); // TypeC => A = 1 , B = 2 , C = 3
            //typeC.Fun02(); // TypeC => A = 1 , B = 2 , C = 3
            //typeD.Fun02(); // TypeE : A = 1 , B = 2 , C = 3 , D = 4 , E = 5 // Here Chain of overrid is breaked because od new keyword 
            //typeE.Fun02(); // TypeE : A = 1 , B = 2 , C = 3 , D = 4 , E = 5 w
            #endregion

            #region Binding Example 04
            //// No Binding
            //FullTimeEmployee employee01 = new FullTimeEmployee();
            //employee01.ID = 1;
            //employee01.Name = "Heba";
            //employee01.Age = 30;
            //employee01.Salary = 20;
            //ProcessEmployee(employee01);

            //Console.WriteLine("===============================");

            //// Binding 
            //Employee employee02 = new FullTimeEmployee();
            //employee02.ID = 2;
            //employee02.Name = "Ahmed";
            //employee02.Age = 23;
            ////employee02.Salary = 200; // invalid [عشان موجود في الابن و مش موجود فس الاب و احنا بنشاور علي الاب]
            //ProcessEmployee((FullTimeEmployee) employee02);

            //Console.WriteLine("===============================");

            //FullTimeEmployee employee03 = new FullTimeEmployee();
            //ProcessEmployee(employee03);
            //Console.WriteLine("===============================");
            //PartTimeEmployee employee04 = new PartTimeEmployee();
            //ProcessEmployee(employee04); 
            #endregion

            #region Interface Example 01
            //// Interface
            //// U Can Not Create an Object [Instance] From Interface
            ////IMyType type = new IMyType(); // Invalid

            //MyType myType = new MyType();
            //myType.Salary = 1;
            //myType.MyFun();
            //Console.WriteLine(myType.MyMethod()); 

            //IMyType ReferenceFromInterface = new MyType();
            //ReferenceFromInterface.Salary = 1;
            //ReferenceFromInterface.Print();
            //ReferenceFromInterface.MyFun();
            //Console.WriteLine(ReferenceFromInterface.MyMethod()); 
            #endregion

            #region Interface Example 02 [Open Close Principle]
            //SeriesByTwo S01 = new SeriesByTwo();
            //PrintTenNumbersFromSeries(S01);
            //Console.WriteLine("===================================");
            //SeriesByThree S02 = new SeriesByThree();
            //PrintTenNumbersFromSeries(S02); 
            #endregion

            #region Object Initializer , Shallow Copy and Deep Copy
            //Interfaces.Employee employee01 = new Interfaces.Employee() { Id = 1, Name = "Heba", Salary = 12103};

            //Interfaces.Employee employee02 = new Interfaces.Employee() { Id = 2, Name = "Mohammed", Salary = 21005, };

            //Interfaces.Employee employee03 = new Interfaces.Employee() { Id = 3, Name = "Ahmed", Salary = 60105, };

            //Console.WriteLine($"Employee01 : {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee02 : {employee02.GetHashCode()}");
            //Console.WriteLine("==============================");
            //employee02 = employee01; // Shallow Copy :: Will Copy Data and Address Thats Mean If U Change In Any Of Them The Change Will Affect On Both
            //// This Object { Id = 1, Name = "Heba", Salary = 12103} :: -> Has 2 References [Employee01 , Employee02]
            //// This Object { Id = 2, Name = "Mohammed", Salary = 21005, } :: -> Became Unreachable Object
            //Console.WriteLine("After Shallow Copy:");
            //Console.WriteLine("==============================");
            //Console.WriteLine($"Employee01 : {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee02 : {employee02.GetHashCode()}");
            //Console.WriteLine("==============================");

            //Console.WriteLine($"Employee01 : {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee03 : {employee03.GetHashCode()}");
            //Console.WriteLine("==============================");
            //employee03 = (Interfaces.Employee)employee01.Clone(); // Deep Copy Using Clone [Implemented From IClonable Interface]
            //// Clone Will Generate New Object With New and Deffirent Identity
            //// But With The Same Data Of Caller Object
            //Console.WriteLine("After Deep Copy:");
            //Console.WriteLine("==============================");
            //Console.WriteLine($"Employee01 : {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee03 : {employee03.GetHashCode()}");
            //Console.WriteLine("=============================="); 
            #endregion

            #region IFlyable and IMovable .. Interfaces
            //Interfaces.Employee[] employees =
            //{
            //    new Interfaces.Employee(){Id = 1 , Name = "Heba" , Salary = 20_000 },
            //    new Interfaces.Employee(){Id = 2 , Name = "Mohammed" , Salary = 150_000},
            //    new Interfaces.Employee(){Id = 3 , Name = "Ahmed" , Salary = 30_000},
            //    new Interfaces.Employee(){Id = 4 , Name = "Ali" , Salary = 40_000}
            //};

            //Array.Sort(employees); // Vaild in Case That Employee Implement IComparable Interface

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            //             // 20_000 < 150_000 -> -1
            //             // 150_000 > 30_000 -> 1
            //int result = employees[1].CompareTo(employees[3]);
            //Console.WriteLine(result);

            //int[] Numbers = { 1, 5, 2, 7, 3, 9, 2, 7, 3, 10, 9 };
            //Array.Sort(Numbers);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //IMoveable moveable = new AirPlane();
            //moveable.Backward(); 
            #endregion

            #region Abstract

            ////Shape shape = new Shape() { Dim01 = 10 , Dim02 = 20}; // Invalid
            //Rectangel rectangel = new Rectangel();
            //rectangel.CalculateArea();
            //rectangel.Print();
            //Shape shape = new Rectangel();
            //shape.CalculateArea();
            //shape.Print();

            #endregion

            #region Operators Overloading

            #region Complex
            //Complex C01 = new Complex() { Real = 10, Imagin = 3 };
            //Complex C02 = new Complex() { Real = 3, Imagin = 4 };
            //Complex C03 = default; // null
            //Console.WriteLine(C01);
            //Console.WriteLine(C02);
            //Console.WriteLine("=================");
            //C03 = C01 + C02;
            //Console.WriteLine(C03); 
            #endregion

            #region Employee Explicit Casting
            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    FullName = "Salma Hany",
            //    Password = "password",
            //    SecurityStamp = "adasa"
            //};

            //EmployeeViewModel employeeViewModel = (EmployeeViewModel) employee;
            //Console.WriteLine($"FristName = {employeeViewModel.FirstName} , LastName = {employeeViewModel.LastName}"); 
            #endregion
            #endregion

            #region Static
            //Utility U01 = new Utility(1 , 2);
            //Utility U02 = new Utility(2 , 3);
            //// The Result Of Calling Method "CmToInch()" Does Not Depend On The Object State [Data (X , Y)] Of U01 , and U02 

            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.CircleArea(10)); 
            #endregion


        }
    }
}
