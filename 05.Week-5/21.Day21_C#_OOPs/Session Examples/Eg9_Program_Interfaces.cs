namespace ConsoleApp39
{
    interface IMathInterface
    {
        int Add(int x, int y);

        int Multiply(int x, int y);

        // Default Interface Methods (DIMs)
        double Power(int x, int y) => Math.Pow(x, y);
    }

    interface IStringInterface
    {
        string Combine(string s1, string s2);

        string ChangeToUpperCase(string s1);
    }

    class TestClass : IMathInterface, IStringInterface
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public string Combine(string s1, string s2)
        {
            return string.Concat(s1, s2);
        }

        public string ChangeToUpperCase(string s1)
        {
            return s1.ToUpper();
        }
    }


    class TestClass2 : IMathInterface
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public double Power(int x, int y)
        {
            double result = 1;

            for (int i = 1; i <= y; i++)
            {
                result = result * x;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            TestClass testClass = new TestClass();


            Console.WriteLine(testClass.Add(10, 20));
            Console.WriteLine(testClass.Multiply(10, 20));
            Console.WriteLine(testClass.Combine("Hello", " World"));
            Console.WriteLine(testClass.ChangeToUpperCase("Working with interfaces"));

            Console.WriteLine("-----------------------------");

            TestClass2 test2 = new TestClass2();
            Console.WriteLine(test2.Add(2,4));
            Console.WriteLine(test2.Multiply(2,4));
            Console.WriteLine(test2.Power(2,4));

            Console.ReadLine();
        }
    }
}
