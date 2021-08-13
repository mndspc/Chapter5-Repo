using System;

namespace ArrayAndCollections
{
    //  This program shows how to use methods and properties from Syste.Array class
    class ArrayClassDemo
    {
        static void Main()
        {
            int[] numsArray = {34,11,3,1,20 };
            int[] dumsArray = new int[5];//{34,11,3,1,20 }
            int[,] multArray = new int[2, 3];

            //  How to copy elments from one array to another
            numsArray.CopyTo(dumsArray, 0);
            Console.WriteLine("After copying elements from numsArray to dumsArray:");
            foreach(var temp in dumsArray)
            {
                Console.Write("{0}\t",temp);
            }
            dumsArray.SetValue(99, 1);
            dumsArray[1] = 99;
            Console.WriteLine("Value at index 1:{0}", dumsArray.GetValue(1));
            Console.WriteLine("Value at index 1:{0}", dumsArray[1]);

            //  How to get upperbound and lowerbound
            Console.WriteLine("Upperbound of dumsArray is:{0} and multArray is:{1}",dumsArray.GetUpperBound(0),multArray.GetUpperBound(1));
            Console.WriteLine("Length of multArray for second dim:{0}",multArray.GetLength(1));
            Console.WriteLine("Type of dumsArray is:{0}",dumsArray.GetType());
            // How get a rank of an array 
            Console.WriteLine("dumsArray has {0} dim. and mulArray has {1} dim.",dumsArray.Rank,multArray.Rank);

            //  How to Sort an Array using static Sort method
            Array.Sort(dumsArray);
            Console.WriteLine("After sorting dumsArray:");
            foreach (var temp in dumsArray)
            {
                Console.Write("{0}\t", temp);
            }
            Console.WriteLine();
            //  How to Reverse an Array using static Reverse method
            Array.Reverse(dumsArray);
            Console.WriteLine("After reversing dumsArray:");
            foreach (var temp in dumsArray)
            {
                Console.Write("{0}\t", temp);
            }
            Console.WriteLine();
            //  How to find out index by passing value using IndexOf static method
            Console.WriteLine("index of value 3 is:{0}", Array.IndexOf(dumsArray, 3));
            //  How to clear elements using Clear static method
            Array.Clear(dumsArray, 0, 2);
            Console.WriteLine("After clearing dumsArray:");
            foreach (var temp in dumsArray)
            {
                Console.Write("{0}\t", temp);
            }
            Console.ReadLine();
        }
    }
}
