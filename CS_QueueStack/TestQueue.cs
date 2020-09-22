using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_QueueStack
{
    public class TestQueue
    {
        public static void AddQueue()
        {
            Queue<string> doc = new Queue<string>();

            doc.Enqueue("Document 1");
            doc.Enqueue("Document 2");
            doc.Enqueue("Document 3");

            while(doc.Count > 0){
                var d = doc.Dequeue();
                System.Console.WriteLine($"{d}, rest of {doc.Count}");
            }
        }
    }
}