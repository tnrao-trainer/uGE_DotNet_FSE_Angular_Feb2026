using System;

namespace ConsoleApp35
{

    class Person
    {
        // data members 
        private string _name = "Scott";
        private int _age = 25;


        // methods 
        public void PrintDetails()
        {
            Console.WriteLine($"Name :  {_name}, Age : {_age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             Person personObj = new Person();
             personObj.PrintDetails();
            
             Console.ReadLine();
        }
    } 
}
