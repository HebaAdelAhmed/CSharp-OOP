using System;
using System.Runtime.Intrinsics.X86;

namespace Session_2._0_Assigement_1._0_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter a number :");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Number is : {num}"); 
            #endregion

            #region 2- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //if(num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region 3- Write a program that allows the user to insert 2 integers then print the max.
            //Console.WriteLine("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //if(num1 > num2)
            //{
            //    Console.WriteLine($"The Max number is {num1}");
            //}
            //else
            //{
            //    Console.WriteLine($"The Max number is {num2}");
            //}

            #endregion

            #region 4- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter number :");
            //int Num1 = int.Parse(Console.ReadLine());
            //if (Num1 < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //} 
            #endregion

            #region 5- Write a program that takes 3 integers from the user then prints the max element and the min element.

            //int Num1 = int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());
            //int Num3 = int.Parse(Console.ReadLine());

            //if (Num1 > Num2 && Num1 > Num3)
            //{
            //    Console.WriteLine(Num1);
            //} else if(Num2 > Num3 && Num2 > Num3)
            //{
            //    Console.WriteLine(Num2);
            //} else
            //{
            //    Console.WriteLine(Num3);
            //}

            #endregion

            #region 6- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //int Num1 = int.Parse(Console.ReadLine());
            //if(Num1 % 2 == 0)
            //{
            //    Console.WriteLine("Even Number");
            //}else
            //{
            //    Console.WriteLine("Odd Number");
            //}

            #endregion

            #region 7- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //char c = char.Parse(Console.ReadLine());

            //switch (c)
            //{
            //    case 'a':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'A':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'e':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'E':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'i':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'I':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'o':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'O':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'u':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'U':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}

            #endregion

            #region 12- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter marks of five subjects :");
            //int SubjectMark1 = int.Parse(Console.ReadLine());
            //int SubjectMark2 = int.Parse(Console.ReadLine());
            //int SubjectMark3 = int.Parse(Console.ReadLine());
            //int SubjectMark4 = int.Parse(Console.ReadLine());
            //int SubjectMark5 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Total Marks : = {SubjectMark1 + SubjectMark2 + SubjectMark3 + SubjectMark4 + SubjectMark5}");
            //Console.WriteLine($"Average Marks : = {(SubjectMark1 + SubjectMark2 + SubjectMark3 + SubjectMark4 + SubjectMark5) / 5}");
            //Console.WriteLine($"Percentage : {(SubjectMark1 + SubjectMark2 + SubjectMark3 + SubjectMark4 + SubjectMark5) / 5} %");

            #endregion

            #region 13- Write a program to input the month number and print the number of days in that month.

            //int MonthNum = int.Parse(Console.ReadLine());

            //switch (MonthNum)
            //{
            //    case 1:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 days");
            //        break;
            //    case 3:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 4:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 5:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 6:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 7:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 8:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 9:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 10:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;
            //    default:
            //        Console.WriteLine("There is no month of this number.");
            //        break;
            //}

            #endregion

            #region 14- Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.

            //int Mark1 = int.Parse(Console.ReadLine());
            //int Mark2 = int.Parse(Console.ReadLine());
            //int Mark3 = int.Parse(Console.ReadLine());
            //int Mark4 = int.Parse(Console.ReadLine());
            //int Mark5 = int.Parse(Console.ReadLine());

            //int Total = Mark1 + Mark2 + Mark3 + Mark4 + Mark5;
            //double Avarage = Total / 5;

            //if(Avarage >= 90)
            //{
            //    Console.WriteLine($"Percentage is {Avarage}: Grad A");
            //}else if(Avarage >= 80)
            //{
            //    Console.WriteLine($"Percentage is {Avarage}: Grad B");
            //}else if(Avarage >= 70)
            //{
            //    Console.WriteLine($"Percentage is {Avarage}: Grad C");
            //}else if(Avarage >= 60)
            //{
            //    Console.WriteLine($"Percentage is {Avarage}: Grad D");
            //}else if (Avarage >=40)
            //{
            //    Console.WriteLine($"Percentage is {Avarage}: Grad E");
            //}
            //else
            //{
            //    Console.WriteLine($"Percentage is {Avarage}: Grad F");
            //}

            #endregion

            #region 15 - Write a program to check whether a number is positive or negative or zero using Switch.

            //int Num = int.Parse(Console.ReadLine());

            //switch (Num < 0)
            //{
            //    case true:
            //        Console.WriteLine("Negative");
            //        break;
            //    case false:
            //        switch (Num > 0)
            //        {
            //            case true:
            //                Console.WriteLine("Positive");
            //                break;
            //            case false:
            //                Console.WriteLine("Zero");
            //                break;
            //        }
            //        break;

            //}

            #endregion

            #region 16- Write a program to create a Simple Calculator using Switch.

            //int Num1 = int.Parse(Console.ReadLine());
            //char c = char.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());

            //switch(c) 
            //{ 
            //    case '+':
            //        Console.WriteLine($"{Num1} + {Num2} = {Num1+Num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{Num1} - {Num2} = {Num1-Num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{Num1} * {Num2} = {Num1*Num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{Num1} / {Num2} = {Num1/Num2}");
            //        break;
            //}

            #endregion
        }
    }
}
