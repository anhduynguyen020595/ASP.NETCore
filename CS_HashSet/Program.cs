using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashSet1 = new HashSet<int>(){
                5,4,2,3,1
            };

            System.Console.WriteLine($"Number of elements in Hash Set 1 is {hashSet1.Count}");

            foreach (var h in hashSet1)
            {
                System.Console.Write(h + " ");
            }
            System.Console.WriteLine();

            HashSet<int> hashSet2 = new HashSet<int>();
            hashSet2.Add(3);
            hashSet2.Add(4);

            if(hashSet1.IsSupersetOf(hashSet2)){
                System.Console.WriteLine("hashSet1 contains hashSet2");
            }
        }
    }
}
