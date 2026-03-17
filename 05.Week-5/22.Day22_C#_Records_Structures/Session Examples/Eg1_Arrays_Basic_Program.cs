namespace ConsoleApp8
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            // Index based
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Item based 
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine();
        }
    }
}
