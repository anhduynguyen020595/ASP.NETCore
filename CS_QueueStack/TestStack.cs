using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_QueueStack
{
    public class TestStack
    {
        public static void AddStack(){
            Stack<string> doc = new Stack<string>();

            doc.Push("Document 1");
            doc.Push("Document 2");
            doc.Push("Document 3");

            while(doc.Count > 0){
                var d = doc.Pop();

                System.Console.WriteLine($"Solved {d}, rest of {doc.Count}");
            }

        }
    }
}