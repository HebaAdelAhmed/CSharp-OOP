using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpDelegate
{
    // Step 0 : Delegate Decleration -> Same Signature Of Function
    //public delegate TResult CompareFuncDelegate<in T ,out TResult> (T a, T b); // U Can Use A Func Delegate Instade Of This 
    // In Func Delegate : Refare To Function That Take A Parameter From 0..16 Parameters and Must Return a Value
    // In Action Delegate : Refare To Function That Take A Parameters From 0..16 Parameters and Must Not To Return Any Thing (void)
    internal class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] Arr , Func<T , T, bool> compareFunc)
        {
            for (int i = 0; i < Arr?.Length; i++)
                for (int j = 0; j < Arr?.Length - i -1; j++)
                    //if (Arr[j] > Arr[j+1])
                    if (compareFunc(Arr[j] , Arr[j+1]))
                        Swap(ref Arr[j+1], ref Arr[j]);

        }

        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
    }

    internal class CompareFunctions
    {
        public static bool CompLengthAscending(string a, string b) { return (a?.Length > b?.Length); } // Sort Ascending
        public static bool CompLengthDescending(string a, string b) { return (a?.Length < b?.Length); } // Sort Ascending
        public static bool CompGreater(int a, int b) { return (a > b); } // Sort Ascending
        public static bool CompLess(int a, int b) { return (a < b); } // Sort Descending
    }
}
