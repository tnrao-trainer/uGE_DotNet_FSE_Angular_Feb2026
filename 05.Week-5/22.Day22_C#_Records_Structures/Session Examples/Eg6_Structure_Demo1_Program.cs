using System;


namespace ConsoleApp8
{

    struct Rectangle
    {
        public int Width;
        public int Height;

        // Constructor
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        // Methods
        public int Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle(5, 10);
            Rectangle r2 = r1;// It copies the values
            r2.Width = 6;

            Console.WriteLine("Area: " + r1.Area());
            Console.WriteLine("Area: " + r2.Area());


            Console.ReadLine();
        }
    }
}