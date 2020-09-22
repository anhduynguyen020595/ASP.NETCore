using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string , int> count = new Dictionary<string, int>()
           {
                ["one"] = 1,
                ["two"] = 2
           };

           count["three"] = 3;

           var keys = count.Keys;
           foreach(var k in keys){
               var value = count[k];
               System.Console.WriteLine($"{k} = {value}");
           }
        }
    }
}
