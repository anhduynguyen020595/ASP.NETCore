using System;

namespace CS_Lambda
{
    class Program
    {
        public delegate int Calculate(int a, int b);
        static void Main(string[] args)
        {
            Calculate sumary = (int x, int y) => { return x + y; };

            Func<int, int, int> sumary1 = (int x, int y) => { return x + y; };

            Action<string> Warning = (message) => {Console.WriteLine("Warning: " + message);};

            int result = sumary(5, 1);
            Console.WriteLine(result);

            int result1 =  sumary1(10, 2);
            Console.WriteLine(result1);

            Warning("Test");
        }
    }
}
