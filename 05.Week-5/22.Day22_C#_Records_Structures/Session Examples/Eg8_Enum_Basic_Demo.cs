using System;


namespace ConsoleApp8
{
    enum Days
    {
        Sunday,
        Monday,
        Tuesday
    }


    class Program
    {
        static void Main()
        {
            Days today = Days.Monday;

            Console.WriteLine(today);        // Output: Monday
            Console.WriteLine((int)today);   // Output: 1

            Console.ReadLine();
        }
    }
}