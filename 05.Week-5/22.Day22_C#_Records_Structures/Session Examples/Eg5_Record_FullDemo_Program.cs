namespace ConsoleApp8
{

    // Simple record
    public record Book(string Title, double Price);

    // Nested record
    public record Address(string City, string Country);
    public record Employee(string Name, Address Address);



    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Simple Record Comparison ===");
            var b1 = new Book("C# Basics", 499);
            var b2 = new Book("C# Basics", 499);
            Console.WriteLine($"Books equal: {b1 == b2}"); // True

            Console.WriteLine($"Title : {b1.Title}, Price : {b1.Price}");

            Console.WriteLine("\n=== Using 'with' Keyword ===");
            var b3 = b1 with { Price = 599 };
            Console.WriteLine(b1);
            Console.WriteLine(b3);

            Console.WriteLine("\n=== Nested Record Comparison ===");
            var e1 = new Employee("Anil", new Address("Hyderabad", "India"));
            var e2 = new Employee("Anil", new Address("Hyderabad", "India"));
            Console.WriteLine($"Employees equal: {e1 == e2}"); // True


            Console.WriteLine("\n=== Deconstruction ===");
            var (name, price) = b1;
            Console.WriteLine($"Name: {name}, Price: {price}");

            Console.ReadLine();
        }
    }

}
