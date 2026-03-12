using System;

namespace ConsoleApp35
{ 
    internal class Program
    {

        static void Greeting()
        {
            Console.WriteLine("Welcome to C# Methods");
        }

        static void Greeting(string  uname)
        {
            Console.WriteLine($"Hi {uname}, Good morning...!");
        }

        static int GetSum(int x, int y)
        {
            int z = x + y;
            return z;
        }


        static string GetCurrentTime()
        {
            string str = DateTime.Now.ToString("T");
            return str;
        }

        static void Main(string[] args)
        {

            Greeting();
            Greeting();
            Console.WriteLine("---------------------------");

            Greeting("Narasimha");
            Greeting("Scott");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Sum Result : " + GetSum(10,20));
            Console.WriteLine("Sum Result : " + GetSum(402,503));

            Console.WriteLine("---------------------------");

            Console.WriteLine("Current Time : " + GetCurrentTime());

            Console.ReadLine();
        }
    }
}
