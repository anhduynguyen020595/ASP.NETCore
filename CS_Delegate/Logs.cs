using System;
namespace CS_Delegate
{
    public class Logs
    {
        // Declare a delegate
        public delegate void ShowLog(string message);

        // The method has structure look like ShowLog method
        public static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        }

        // The another method has structure look like ShowLog method
        public static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Warning: {0}", s));
            Console.ResetColor();
        }

        public static void TestShowLog(){
            ShowLog log;
            
            log = Info;
            log("Test Information");

            log = Warning;
            log("Test Warning");
        }

        public static void TestShowLogMulti(){
            ShowLog log = null;

            log += Warning;
            log += Info;
            log += Warning;

            // Anonymou method
            log += (x) => Console.WriteLine(string.Format("===>{0}<===", x));

            log("Test Log");
        }
    }
}