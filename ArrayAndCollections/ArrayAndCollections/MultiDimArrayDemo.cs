using System;

namespace ArrayAndCollections
{
    class MultiDimArrayDemo
    {
        //  This program shows how can declare multi. dim. array.
        static void Main()
        {
            // How to declare multi dim array with default values
            int[,] numsArray = { {23,12,43 },{44,23,56} };
            // How to declare multi dim array with default values using new keyword
            int[,] numsArray1 = new int [,]{ { 23, 12, 43 }, { 44, 23,66} };
            //  How to declare array with size
            int[,] numsArray2 = new int[2, 3];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    numsArray2[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Array Elements are:");
            for (int i = 0; i < numsArray2.GetLength(0); i++)
            {
                for (int j = 0; j < numsArray2.GetLength(1); j++)
                {
                    Console.Write("{0}\t", numsArray2[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
