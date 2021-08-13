using System;
using System.Collections;
namespace ArrayAndCollections
{
    //  This program demo. how to use HashTable and SortedList non-generic collection 
    class HashTableAndSortedListDemo
    {
        static void Main()
        {
            //  HashTable and SortedList maintain data in pairs (key and value)
            Hashtable gstStateCodes = new Hashtable();
            gstStateCodes.Add("MH",27);
            gstStateCodes.Add("GJ",24);
            gstStateCodes.Add("KA",29);
            gstStateCodes.Add("TL",36);
            gstStateCodes.Add("AP",28);
            gstStateCodes.Add("DL",7);
            Console.WriteLine("Count is:{0}",gstStateCodes.Count);

            Console.WriteLine("GST Code of AP:{0}", gstStateCodes["AP"]);
            gstStateCodes["AP"] = 29;
            Console.WriteLine("GST Code of AP:{0} after modifying", gstStateCodes["AP"]);

            foreach(var key in gstStateCodes.Keys)
            {
                Console.WriteLine("Key={0} and Value={1}",key,gstStateCodes[key]);
            }
            gstStateCodes.Remove("DL");
            Console.WriteLine("After Removing DL");
            foreach (var key in gstStateCodes.Keys)
            {
                Console.WriteLine("Key={0} and Value={1}", key, gstStateCodes[key]);
            }
            Console.WriteLine("Sorted List data");
            SortedList sortedList = new SortedList();
            sortedList.Add("xyz",23);
            sortedList.Add("abc",2);
            sortedList.Add( "hello",22);
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine("Key={0} and Value={1}", key, sortedList[key]);
            }

            Console.ReadLine();
        }
    }
}
