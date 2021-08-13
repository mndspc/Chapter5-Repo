using System;
using System.Collections;

namespace ArrayAndCollections
{
    // This program shows how we can use Queue Non-Generic colletion class.
    class QueueDemo
    {
        static void Main()
        {
            // Queue has FIFO principle
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue(124);
            q.Enqueue(125);
            q.Enqueue(126);
            Console.WriteLine("Count is:{0}",q.Count);
            foreach(var temp in q)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("After removing :{0}", q.Dequeue());

            foreach (var temp in q)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("Next element to be remove is:{0}", q.Peek());

            Console.ReadLine();
        }
    }
}
