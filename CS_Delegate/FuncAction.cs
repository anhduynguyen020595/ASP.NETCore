using System;
namespace CS_Delegate
{
    public class FuncAction
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void TestFunc(int x, int y)
        {
            Func<int, int, int> sumary = Sum;

            var result = sumary(x, y);
            Console.WriteLine(result);
        }

        public static void TesAction(string s){
            Action<string> log = null;

            log += Logs.Warning;
            log += Logs.Info;
            log += Logs.Warning;

            log(s);
        }
    }
}