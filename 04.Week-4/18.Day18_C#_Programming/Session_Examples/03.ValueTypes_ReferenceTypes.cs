using System;

namespace ConsoleApp35
{
    class Student
    {
        public int Id;
        public string Name;
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;

            Console.WriteLine($"a = {a}, b = {b}");
            b = 15;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("------------------------");


            // Reference Types
            Student s1 = new Student();
            s1.Name = "Scott";
            s1.Id = 101;

            Student s2 = s1;


            Console.WriteLine($"s1 - Name :  {s1.Name}, s2 - Name :  {s2.Name}");

            s2.Name = "Smith";

            Console.WriteLine($"s1 - Name :  {s1.Name}, s2 - Name :  {s2.Name}");
 

            Console.ReadLine();
        }
    }
}
