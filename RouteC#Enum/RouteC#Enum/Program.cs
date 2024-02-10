using System;

namespace RouteC_Enum
{
    internal class Program
    {
        [Flags] // Data Annotation
        enum Premmession: byte
        {
            Delete = 1 , Execute = 2 , Read = 4 , Write = 8
        }


        static void Main(string[] args)
        {
            Premmession P01 = Premmession.Delete;
            // If U Want To Add Premmession Do XOR ^
            P01 = P01 ^ Premmession.Execute;
            Console.WriteLine(P01);

            // If U Want To Remove [Deny] Premmession Do XOR ^
            P01 = P01 ^ Premmession.Execute;
            Console.WriteLine(P01);
            //P01 = (Premmession) 3;
            P01 = P01 & Premmession.Read;

            Premmession P02 = (Premmession) 3;
            // If U Want to Check if [Delete] Premmession is Exist Or Not , Use AND & Operator
            if((P02 & Premmession.Delete) == Premmession.Delete)
                Console.WriteLine("Delete is Existed");
            Console.WriteLine(P02);
        }
    }
}
