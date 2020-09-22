using System;
namespace CS_ExtensionMethod
{
    public static class MyExtensionMethods
    {
         public static void Print(this string s, ConsoleColor color = ConsoleColor.Yellow){
            ConsoleColor lastColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            System.Console.WriteLine(s);
            Console.ForegroundColor = lastColor;
        }
    }
}