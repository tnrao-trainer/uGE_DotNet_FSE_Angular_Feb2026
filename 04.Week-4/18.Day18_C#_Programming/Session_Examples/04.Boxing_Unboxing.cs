using System;

namespace ConsoleApp35
{    

    internal class Program
    { 
        static void Main(string[] args)
        {

            int x = 10;
            double d = 45.236;
         

            Object obj1 = x;    // boxing
            Object obj2 = d;    // boxing

            int y = (int) obj1;  // unboxing
            double d2 = (double) obj2;  // unboxing


            Console.WriteLine(y);
            Console.WriteLine(d2);


        //    int z = (int)obj2;  //  error: Invalid Type Casting
        //    Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
