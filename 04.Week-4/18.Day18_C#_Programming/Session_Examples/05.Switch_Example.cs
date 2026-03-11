using System;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number - 1 :  ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number - 2 :  ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Operator [ +  -  *  / ]:  ");
        char op = char.Parse(Console.ReadLine());

        int z = 0;

        // Switch Case
        switch (op) {
            case '+':
                z = x + y;
                break;

            case '-':
                z = x - y;
                break;

            case '*':
                z = x * y;
                break;

            case '/':
                z = x / y;
                break;

            default:
                Console.WriteLine("Invalid Operation");
                Console.ReadLine();
                return;               
            }

        
        Console.WriteLine("Final Result : " + z);

        Console.ReadLine();
        }
}
