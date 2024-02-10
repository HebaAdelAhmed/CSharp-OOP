using System;
using System.Text;

namespace StringBuilderSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String

            /// String is a reference type. but trade like a value type.
            /// immutable type can't change its value.
            //string Name1;
            ///// Declare a Reference from type string.
            ///// refareing to default value of reference type = Null
            
            //Name1 = new string("Heba");
            //Console.WriteLine($"Name 1 'Heba' HashCode(): {Name1.GetHashCode()}");
            //string Name2 = "Aya";
            //Console.WriteLine($"Name 2 'Aya' HashCode(): {Name2.GetHashCode()}");
            //Console.WriteLine("After Assign Name2 = Name1: ");
            //Name2 = Name1; // -> 'Heba'
            //Console.WriteLine($"Name 2 that was aya and now is 'Heba' HashCode(): {Name2.GetHashCode()}");
            //Console.WriteLine($"Name 1 that was heba and still 'Heba' HashCode(): {Name1.GetHashCode()}");
            //Name1 = "Salma";
            //Console.WriteLine($"After change Name 1 from 'Heba' to salma HashCode(): {Name1.GetHashCode()}");
            //Console.WriteLine("Name 2 is still heba : because it allocate a new location in heap");
            //Console.WriteLine(Name2);

            #endregion

            #region String Builder

            /// StringBuilder is a refernce type , and trade like a reference type.
            /// muatable type can change its value. 
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine($"String buider that with null value : stringBuilder.GetHashCode(): {stringBuilder.GetHashCode()}");
            stringBuilder.Append("Hello");
            Console.WriteLine($"String buider after initial value : stringBuilder.GetHashCode(): {stringBuilder.GetHashCode()}");
            stringBuilder.Append(" Heba");
            Console.WriteLine(stringBuilder);
            #endregion
        }
    }
}
