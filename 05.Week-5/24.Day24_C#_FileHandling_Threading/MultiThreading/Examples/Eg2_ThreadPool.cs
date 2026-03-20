using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            int taskId = i;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                Console.WriteLine($"Task {taskId} started.");
                Thread.Sleep(2000);
                Console.WriteLine($"Task {taskId} completed.");
            });
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}