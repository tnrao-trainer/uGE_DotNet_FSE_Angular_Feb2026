	
namespace ConsoleApp41
{
    class Program
    { 
        static void Main(string[] args)
        {

          //  1.Type Pattern

           var obj = "Hello";

            // Type Checking and Assignment
            if (obj is string str)
            {
                Console.WriteLine(str.Length);
            }

            Console.WriteLine("-------------------------------");

            //   2.Switch Expression(C# 8+)

            int number = 10;

            string result = number switch
            {
                > 0 => "Positive",
                < 0 => "Negative",
                0 => "Zero"
            };

            Console.WriteLine(result);

            Console.WriteLine("-------------------------------");

            // 3.Property Pattern  --  Match object properties:

            var person = (Name: "Alice", Age: 28);

            if (person is { Name: "Alice", Age: > 18 })
            {
                Console.WriteLine("Adult Alice");
            }
            Console.WriteLine("-------------------------------");

            //  4.Tuple Pattern:  Match tuples directly:

            var point = (x: 3, y: 2);

            string location = point switch
            {
                (0, 0) => "Origin",
                (0, _) => "Y-axis",
                (_, 0) => "X-axis",
                _ => "Somewhere else"
            };

            Console.WriteLine(location);

            Console.ReadLine();
        }
    }
}