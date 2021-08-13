using System;
using System.Collections;

namespace ArrayAndCollections
{
    // This program demo. how to work with Stack non-generic collection
    class StackDemo
    {
        static void Main()
        {
            // Stack work on LIFO principle
            Stack stk = new Stack();
            stk.Push(10);
            stk.Push(11);
            stk.Push(12);
            stk.Push(13);
            stk.Push(14);
            stk.Push(15);
            Console.WriteLine("Count is:{0}",stk.Count);
            foreach(var temp in stk)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("After removing:{0}", stk.Pop());
            foreach(var temp in stk)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("Next element to be remove is {0}",stk.Peek());
            Console.ReadLine();
        }
    }
}
