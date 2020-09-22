using System;

namespace CS_Generic
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Swap<int> (ref a, ref b);
            System.Console.WriteLine($"a= {a}; b = {b}");


            string a1 = "A";
            string a2 = "B";

            Swap<string>(ref a1, ref a2);
            System.Console.WriteLine($"a1 = {a1}; a2 = {a2}");


            MyClass<double> myClass = new MyClass<double>(123.123);
            myClass.TestMethod(123);
        }
    }
}
