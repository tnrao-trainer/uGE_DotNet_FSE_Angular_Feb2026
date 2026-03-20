 
namespace ConsoleApp41
{

    // Positional Pattern:  Works with deconstructable objects:
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }
 


class Program
    { 
        static void Main(string[] args)
        {
            var person = new Person("Alice", 15);

            if (person is ("Alice", > 18))
            {
                Console.WriteLine("Match found");
            }
            else
            {
                Console.WriteLine("Match not found");
            }


                Console.ReadLine();
        }
    } 

}