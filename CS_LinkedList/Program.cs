using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> Lessons = new LinkedList<string>();

            Lessons.AddFirst("Lesson 1");
            Lessons.AddFirst("Lesson 2");
            Lessons.AddFirst("Lesson 3");
            Lessons.AddFirst("Lesson 4");

            System.Console.WriteLine("======== Frist to Last");
            LinkedListNode<string> node = Lessons.First;
            while (node != null)
            {
                System.Console.WriteLine(node.Value);
                node = node.Next;
            }

            System.Console.WriteLine("======== Last to First");
            node = Lessons.Last;
            while(node != null){
                System.Console.WriteLine(node.Value);
                node= node.Previous;
            }

        }
    }
}
