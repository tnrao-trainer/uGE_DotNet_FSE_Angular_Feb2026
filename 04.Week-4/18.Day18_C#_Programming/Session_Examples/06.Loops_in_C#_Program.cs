using System;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        int i = 1;

        Console.WriteLine("Using While Loop : ");
        while (i <= 10)
        {
            Console.Write(" " + i);
            i++;
        }

        Console.WriteLine();


        i = 10;

        Console.WriteLine("Using Do...While Loop : ");
        do
        {
            Console.Write(" " + i);
            i--;
        } while (i >= 1);

        Console.WriteLine();


        Console.WriteLine("Using For Loop : ");
        for (int j = 1; j <= 10; j++)
        {
            Console.Write(" " + j * 2);
        }

        Console.WriteLine();

        Console.ReadLine();
    }
}
