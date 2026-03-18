using System.Collections.Generic; 

namespace ConsoleApp8
{
 
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> studentMarks = new Dictionary<string, int>();

            studentMarks["Ravi"] = 85;
            studentMarks["Anita"] = 90;
            studentMarks["Kiran"] = 78;

            Console.WriteLine(studentMarks["Ravi"]); // 85

            Console.WriteLine();

            // Loop through dictionary
            foreach (var item in studentMarks)
            {
                Console.WriteLine($"Key : {item.Key}, Value : {item.Value}");
            }


            Console.ReadLine();
        }
    }

}
