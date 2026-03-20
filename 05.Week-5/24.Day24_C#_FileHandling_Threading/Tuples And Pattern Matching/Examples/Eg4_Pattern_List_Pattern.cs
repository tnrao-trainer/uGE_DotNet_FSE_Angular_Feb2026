 

namespace ConsoleApp41
{ 
class Program
    { 
        static void Main(string[] args)
        {
            // List Patterns(C# 11+)

            int[] numbers = { 1, 2, 3 };

            if (numbers is [1, 2, 3])
            {
                Console.WriteLine("Exact match");
            }
            else
            {
                Console.WriteLine("Not match");
            }


                Console.ReadLine();
        }
    } 

}