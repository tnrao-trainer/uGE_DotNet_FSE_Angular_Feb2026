using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // ThreadStart delegate used in the Thread class constructor
        Thread thread = new Thread(() =>
        {
            int result = Factorial(3);
            Console.WriteLine($"Factorial result: {result}");
        });

        thread.Start();
        thread.Join(); // Wait for thread to finish


        Console.WriteLine("Main thread finished.");

        Console.ReadLine();
    }

    static int Factorial(int n)
    {
      return   (n <= 1) ? 1 : n * Factorial(n - 1);
    }
     
}