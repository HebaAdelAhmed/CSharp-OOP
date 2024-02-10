using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession2.Operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imagin { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imagin}i";
        }

        #region Operating Overloading

        /// Operator Overloading = Must Be Non Private - Static Member Function
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imagin = (Left?.Imagin ?? 0) + (Right?.Imagin ?? 0),
            };
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imagin = (Left?.Imagin ?? 0) - (Right?.Imagin ?? 0),
            };
        }

        public static Complex operator ++ (Complex C)
        {
            return new Complex
            {
                Real = (C?.Real ?? 0) + 1,
                Imagin = (C?.Imagin ?? 0 ),
            };
        }

        public static Complex operator --(Complex C)
        {
            return new Complex
            {
                Real = (C?.Real ?? 0) - 1,
                Imagin = (C?.Imagin ?? 0),
            };
        }

        public static bool operator > (Complex Right , Complex Left)
        {
            if ((Left?.Real?? 0) == (Right?.Real?? 0))
                return ((Left?.Imagin?? 0) > (Right?.Imagin?? 0));
            else
                return (Left?.Real?? 0) > (Right?.Real ?? 0);
        }

        public static bool operator < (Complex Right, Complex Left)
        {
            if ((Left?.Real?? 0) == (Right?.Real?? 0))
                return ((Left?.Imagin?? 0) < (Right?.Imagin?? 0));
            else
                return (Left?.Real?? 0) < (Right?.Real ?? 0);
        }

        #endregion
    }
}
