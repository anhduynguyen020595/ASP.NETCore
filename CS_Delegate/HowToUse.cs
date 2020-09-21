using System;

namespace CS_Delegate
{
    public class HowToUse
    {
        // Use delegate as parameter, to asign call back
        static void Sumary(int a, int b, Action<string> callback)
        {
            int c = a + b;
            callback(c.ToString());
        }

        public static void TestSumary (){
            Sumary(1, 2, (x) => Console.WriteLine($"Sum of 2 numbers is: {x}"));
            Sumary(1,5, Logs.Info);
        }
    }
}