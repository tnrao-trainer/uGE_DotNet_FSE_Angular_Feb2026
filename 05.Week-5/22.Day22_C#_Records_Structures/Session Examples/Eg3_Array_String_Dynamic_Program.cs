namespace ConsoleApp8
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities;

            Console.WriteLine("Enter no. of cities : ");
            int n = int.Parse(Console.ReadLine());

            cities = new string[n];
            Console.WriteLine($"Enter {n} city names : ");

            for (int i = 0; i < cities.Length; i++)
            {
                cities[i] = Console.ReadLine();
            }


            Console.WriteLine("-------------");
            foreach (string city in cities)
            {
                Console.Write(" " + city);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
