using System;
using System.Collections;
namespace ArrayAndCollections
{
    //  This program shows how to use ArrayList class
    class ArrayListDemo
    {
        static void Main()
        {
            //  How to declare an object of ArrayList
            ArrayList stdArray = new ArrayList();
            stdArray.Add(100);//RollNo
            stdArray.Add("Scott");//Name
            stdArray.Add('M');//Gender
            stdArray.Add(true);//IsNewlyEnrolled
            stdArray.Add("Pune");//City
            stdArray.Capacity = stdArray.Count;
            Console.WriteLine("Count is:{0} and Capacity is:{1}",stdArray.Count,stdArray.Capacity);
            foreach(var temp in stdArray)
            {
                Console.WriteLine(temp);
            }
            stdArray.Remove("Pune");
            stdArray.Capacity = stdArray.Count;
            Console.WriteLine("Count is:{0} and Capacity is:{1}", stdArray.Count, stdArray.Capacity);
            Console.WriteLine("After removing Element");
            foreach (var temp in stdArray)
            {
                Console.WriteLine(temp);
            }
           if(stdArray.Contains(100))
            {
                Console.WriteLine("100 is present");
            }
            else
            {
                Console.WriteLine("100 is not present");
            }
            stdArray.Clear();
            Console.WriteLine("Count is:{0} and Capacity is:{1}", stdArray.Count, stdArray.Capacity);
            Console.ReadLine();
        }
    }
}
