using System;
using Common;
using RouteC_OOPSession.Inheratince;

namespace RouteC_OOPSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA typeA = new TypeA(); // Invalid in case Class Of TypeA is Internal - And Valed In case That Class Of TypeA is Public
            typeA.F = 10; // public 

            #region Struct Ex01 Point:
            //Point P1; // Struct is a Value Type Not Reference Type.
            ///// Allocate for 8 Uninitialized Byte at STACK

            //P1 = new Point();
            ///// new -> Is Only For Selection The Constructor Which Initialize The Attributes Of The Object
            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1.Y);

            //Point P2 = new Point(X: 20, Y: 30);
            //Console.WriteLine(P2.X);
            //Console.WriteLine(P2.Y);

            //Console.WriteLine(P1.ToString()); //default of using ToString(): Namespace.StructName [RouteC_OOPSession.Point]
            //Console.WriteLine(P1.ToString()); // After override []: X = {x value} , And Y = {y value}
            //Console.WriteLine(P1); // Default Run ToString  
            #endregion

            #region Struct Ex02 Employee

            //Employee E01 = new Employee(id: 10 , name: "Heba Adel" , age: 23 , salary: 15000 , address: "Cairo");
            //Console.WriteLine(E01.ToString());
            //E01.name = "Heba"; // Using Attribute It Self
            //E01.SetId(2000); // Not Achive Cause Of Condition. // Using Setter 
            //Console.WriteLine(E01.GetId()); // Using Getter
            //E01.Salary = 18000;
            //Console.WriteLine(E01.Salary); // Using Property [Full Property]
            //Console.WriteLine(E01.Address); // Using Property [Automatic Proparty]

            #endregion

            #region PhoneBook Ex03

            //PhoneBook phoneBook = new PhoneBook(_size: 3);
            //phoneBook.AddPerson(0 , "Heba Adel" , 01001394765);
            //phoneBook.AddPerson(1 , "Thanaa Ahmed" , 01018050719);
            //phoneBook.AddPerson(2 , "Ahmed Ezz Eldin" , 01280146613);
            ////Console.WriteLine(phoneBook.GetPhoneNumberUsingName("Heba Adel")); ;
            ////Console.WriteLine("====================");
            ////phoneBook.UpdatePhoneNumberUsingName(Name: "Heba Adel" , 18050719);
            ////Console.WriteLine(phoneBook.GetPhoneNumberUsingName("Heba Adel"));
            ////Console.WriteLine("====================");
            ////phoneBook["Thanaa Ahmed"] = 10; // Using Indexer Way -> Set
            ////Console.WriteLine(phoneBook["Thanaa Ahmed"]); // Use Indexer Way -> Get

            //for (int i = 0; i < phoneBook.Size; i++)
            //{
            //    Console.WriteLine(phoneBook[i]);
            //}

            #endregion

            //Car C1;
            //// C1 is a refrernce from type car
            //// 1. May refer to an object from type Car
            //// Or
            //// 2. May refer to object from class inhereting from Car 
            //// [ياما هيشاور على اوبجيكت من كار او هيشاور على اوبجيكت من كلاس بيورث من الكار]

            ////C1 = new Car();
            ////C1 = new BMWCar();

            //C1 = new Car(10 , "BMW" , 50);
            //Console.WriteLine(C1.ToString());

            //Parent P01 = new Parent(10, 20);

            Child C01 = new Child(10 , 20 , 2);
            Console.WriteLine(C01);

        }
    }
}
