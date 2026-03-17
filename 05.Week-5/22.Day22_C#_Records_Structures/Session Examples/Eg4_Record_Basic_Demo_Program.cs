namespace ConsoleApp8
{
 
     public record Person(string Name, int Age);


    /*
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string  name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    */

    class Program
    {
        static void Main()
        {
            Person p1 = new Person("Scott", 25);
            Person p2 = new Person("Scott", 25);

            Console.WriteLine(p1 == p2);  // true

            Console.ReadLine();
        }
    }
 
}
