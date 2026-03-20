 

namespace ConsoleApp41
{
    class Program
    {

        //  Returning Tuples from the method 
        static (int Empno, string Ename)  GetEmpData()
        {
            int eno = 102303;
            string ename = "Scott";
            return (eno, ename);
        }

        static void Main(string[] args)
        {
            // Basic way of Creating Tuples
            var person = ("Alice", 18, "Student");
            Console.WriteLine(person);

        //    Console.WriteLine(person[0]);  // wrong
        //    Console.WriteLine(person.name);  // wrong
        //      Console.WriteLine(person(0);  // wrong
              Console.WriteLine(person.Item1);  // correct
              Console.WriteLine(person.Item2);  // correct
              Console.WriteLine(person.Item3);  // correct


            Console.WriteLine("-----------------------------");


           // Named Tuples(Enhancement), You can give names to elements:
            var person2 = (Name: "Alice", Age: 18, Role: "Student");
            Console.WriteLine(person2);
            Console.WriteLine(person2.Name);
            Console.WriteLine(person2.Age);
            Console.WriteLine(person2.Role);

            Console.WriteLine("-----------------------------");

            var emp1 = GetEmpData();
            Console.WriteLine(emp1);
            Console.WriteLine(emp1.Empno);
            Console.WriteLine(emp1.Ename);

            Console.WriteLine("-----------------------------");

            //  Tuple Deconstruction
            var (x, y) = GetEmpData();
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}