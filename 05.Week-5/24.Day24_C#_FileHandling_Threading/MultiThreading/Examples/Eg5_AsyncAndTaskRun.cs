using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int result = await Task.Run(() => Fibonacci(n));
        Console.WriteLine($"Fibonacci({n}) = {result}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}