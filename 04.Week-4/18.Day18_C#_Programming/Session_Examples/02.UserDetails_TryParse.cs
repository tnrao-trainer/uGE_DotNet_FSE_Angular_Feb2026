using System;

namespace ConsoleApp35
{
    internal class Program
    {
        static bool IsValidAge(int age)
        {
            if (age < 20 || age > 40)
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            string userName;
            string emailId;
            int age;
            bool isValidUser;


            Console.WriteLine("Enter user name : ");
            userName = Console.ReadLine();

            Console.WriteLine("Enter user email id : ");
            emailId = Console.ReadLine();

            Console.WriteLine("Enter user age : ");


           bool flag =  int.TryParse(Console.ReadLine(), out age);

            if (flag == false)
            {
                Console.WriteLine("Invalid Number format.");
                Console.ReadLine();
                return; // exit or return from Main
            }

            isValidUser = IsValidAge(age);



            Console.WriteLine("****** User Details *********");
            Console.WriteLine($"User Name : {userName}");
            Console.WriteLine($"User Age : {age}");
            Console.WriteLine($"User Email : {emailId}");
            Console.WriteLine($"Is Valid User : {isValidUser}");


            Console.ReadLine();
        }
    }
}
