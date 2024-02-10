using System;

namespace ConditionalStatmentSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conditional Statment: If -- Switch

            //Console.Write("Please Enter Month Number That Exist In The First Quarter: ");
            //int MonthNum = int.Parse(Console.ReadLine());

            //if (MonthNum == 1 )
            //{
            //    Console.WriteLine("Jan.");
            //}else if (MonthNum == 2 )
            //{
            //    Console.WriteLine("Feb.");
            //}else if(MonthNum == 3)
            //{
            //    Console.WriteLine("March");
            //}else { Console.WriteLine("Not Exist in the First Quarter."); }

            //switch (MonthNum)
            //{
            //    case 1:
            //        Console.WriteLine("JAN");
            //        break;
            //    case 2:
            //        Console.WriteLine("FEB");
            //        break;
            //    case 3:
            //        Console.WriteLine("MAR");
            //        break;
            //    default: Console.WriteLine("Not Exist in the First Quarter.");
            //        break;
            //}

            Console.WriteLine("Enter Your Name:");
            string Name = Console.ReadLine();

            //if (Name == "Heba")
            //    Console.WriteLine("Hello Heba");
            //else if (Name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            
            //JUMP TABLE -> Use this with numbers or string more than 5 cases.
            switch (Name)
            {
                case "Heba":
                    Console.WriteLine("Hello Heba");
                    break;
                case "Ahmed":
                    Console.WriteLine("Hello Ahmed");
                    break;
                case "Mohammed":
                    Console.WriteLine("Hello Mohammed");
                    break;
                case "Nada":
                    Console.WriteLine("Hello Heba");
                    break;
                case "Hoda":
                    Console.WriteLine("Hello Ahmed");
                    break;
                case "Salma":
                    Console.WriteLine("Hello Mohammed");
                    break;
            }

            #endregion
        }
    }
}
