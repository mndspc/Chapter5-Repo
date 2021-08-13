using System;
using System.Collections.Generic;

namespace ArrayAndCollections
{
    // This program Demo. how to use List<T> 
    class ListGenericDemo
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(123);
            //intList.Add("abc"); //Error

            HashSet<int> hashList = new HashSet<int>();
            hashList.Add(11);
            hashList.Add(12);
            hashList.Add(13);
            hashList.Add(11);
            hashList.Add(12);

            foreach(var hash in hashList)
            {
                Console.WriteLine(hash);
            }
            Console.ReadLine();
        }
    }
}
