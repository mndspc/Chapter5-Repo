using System;
using System.Collections.Generic;

namespace ArrayAndCollections
{
    //  This program shows how to use Queue<T> and Stack<T> class
    //  Generic process gives us type safety and performance over a non-generic
    class QueueAndStackGenericDemo
    {
        static void Main()
        {
            // Stack<T> and Queue<T> can hold a single type of data
            Stack<int> stkInt = new Stack<int>();
            stkInt.Push(100);
            //stkInt.Push("hello"); //Error

            Queue<string> qStr = new Queue<string>();
            qStr.Enqueue("Hello");
            //qStr.Enqueue(123);//Error
        }
    }
}
