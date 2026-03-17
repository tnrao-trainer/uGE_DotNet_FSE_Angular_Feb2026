namespace ConsoleApp8
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int sum = 0;

            // Index based
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Sum Result : " + sum);
             

            Console.ReadLine();
        }
    }
}
