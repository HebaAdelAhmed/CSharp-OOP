using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpAdvanced
{
    // Generic Class // Should Take Its Type When It Call
    internal class Helper<T> where T : IComparable<T>
    // T : Must be class or struct and implementing The IComparable Interface
    {
        #region Non Generic Swap
        //public static void Swap(ref int X, ref int Y)
        //{
        //    Console.WriteLine("========= Swapping ==========");
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void Swap(ref double X, ref double Y)
        //{
        //    Console.WriteLine("========= Swapping ==========");
        //    double temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Console.WriteLine("========= Swapping ==========");
        //    Point temp = X;
        //    X = Y;
        //    Y = temp;
        //} 
        #endregion

        public static void Swap(ref T X, ref T Y)
        {
            Console.WriteLine("========= Swapping ==========");
            T temp = X;
            X = Y;
            Y = temp;
        }

        public static int SearchInArray(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Value.Equals(Arr[i]))
                    return i;
            }
            return -1;
        }

        public static void BubbleSort(T[] Arr)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                for (int j = 0; j < Arr?.Length - i - 1; j++)
                {
                    if (Arr[j].CompareTo(Arr[j+1]) == 1)
                        Swap(ref Arr[j], ref Arr[j+1]);
                }
            }
        }
    }
}
