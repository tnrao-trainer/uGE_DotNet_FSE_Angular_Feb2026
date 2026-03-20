using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


public delegate void MathDelegate(int x, int y);

public class MathTest
{
    public void Sum(int x, int y)
    {
        Console.WriteLine($"Sum Result : {x+ y}");
    }

    public void Multiply(int x, int y)
    {
        Console.WriteLine($"Multiply Result : {x * y}");
    }
}
class Program
{    
    static  void Main()
    {
        MathTest obj = new MathTest ();

        // 1. Named Methods
        MathDelegate d1 = new MathDelegate(obj.Multiply);
        d1(10, 20);


        // 2. Anonymous Methods
        MathDelegate d2 = delegate (int x, int y)
        {
            Console.WriteLine($"Subtract Result :  {x - y}");
        };
        d2(45, 24);


        // 3.  Lambda Expressions / Expressions Methods
        MathDelegate d3 = (x, y) => 
        {
            Console.WriteLine($"Division Result :  {x / y}");
        };

        d3(25, 5);

        Console.ReadLine();
        
    }    
}