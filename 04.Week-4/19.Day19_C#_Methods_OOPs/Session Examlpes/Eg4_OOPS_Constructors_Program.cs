using System;

namespace ConsoleApp35
{

    class Person
    {
        // data members 
        private string _name;
        private int _age;


        public Person() { 
            _name = string.Empty;   
            _age = 0;           
        }

        public Person(string name)
        {
            _name = name;
            _age = 0;
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

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
             Person p1 = new Person();
             Person p2 = new Person("Scott");
             Person p3 = new Person("Smith", 26);



            p1.PrintDetails();
            p2.PrintDetails();
            p3.PrintDetails();

             
            
            Console.ReadLine();
        }
    } 
}
