using System;
using System.Collections.Generic;


namespace ArrayAndCollections
{
    //  This program shows how to use Dictionary<T,T> and SortedList<T,T>
    class DictionaryAndSortedListGenericDemo
    {
        static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(10,"Ten");

            SortedList<int, string> sorted = new SortedList<int, string>();
            sorted.Add(10,"One");
            sorted.Add(1,"Ten");

            Console.ReadLine();
        }
    }
}
