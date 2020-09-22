using System;

namespace CS_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Test extension method...";
            s.Print();
            "Hello World!".Print(ConsoleColor.Red);
        }

       
    }
}
