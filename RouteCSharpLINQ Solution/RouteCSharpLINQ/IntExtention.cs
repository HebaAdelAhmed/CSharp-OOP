using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpLINQ
{
    internal static class IntExtention
    {
        public static int Reverse(this int number)
        {
            int reversedNumber = 0, reminder;
            while(number != 0)
            {
                reminder = number % 10;
                reversedNumber = reversedNumber * 10 + reminder;
                number = number / 10;
            }
            return reversedNumber;
        }
    }
}
