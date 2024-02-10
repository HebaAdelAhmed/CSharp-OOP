using System;
using System.Linq;

namespace Session_3._0_Assigement_1._0_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Size;
            //bool Flag;
            //do
            //{
            //    Console.Write("Enter Size of Array:");
            //    Flag = int.TryParse(Console.ReadLine(), out Size);  
            //}while (!Flag);

            //int[] Arr = new int[Size];
            //for (int i = 0; i < Size; i++)
            //{
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //int Distance = 0;
            //for (int i = 0;i < Arr.Length;i++)
            //{
            //    for(int j = 1; j < Arr.Length;j++)
            //    {
            //        if (Arr[i] == Arr[j])
            //        {
            //            Distance = j - i;
            //        }
            //    }
            //}
            //Console.WriteLine(Distance);

            Console.WriteLine("Enter String:");
            String s = Console.ReadLine();
            String[] arr = s.Split();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
