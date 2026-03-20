using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        Task[] tasks = new Task[3];
        for (int i = 0; i < 3; i++)
        {
            tasks[i] = Task.Run(() => HeavyWork());
        }

        Task.WaitAll(tasks);
        sw.Stop();

        Console.WriteLine($"All tasks completed in {sw.ElapsedMilliseconds} ms.");
    }

    static void HeavyWork()
    {
        double result = 0;
        for (int i = 0; i < 10_000_000; i++)
            result += Math.Sqrt(i);
    }
}