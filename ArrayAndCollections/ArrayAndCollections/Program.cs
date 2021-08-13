using System;

namespace ArrayAndCollections
{
    class Program
    {
        //  This program shows how to declare and init. array
        static void Main(string[] args)
        {
            try
            {
                // How to declare array and init. with default values
                int[] numsArray = { 12, 33, 44, 23, 25, 20 };
                // How to declare array and init. with default values using new keyword
                int[] numsArray2 = new int[] { 12, 33, 44, 23, 25, 20 };

                //  How to declare array with size
                int[] numsArray1 = new int[5];
                numsArray1[0] = 10;
                numsArray1[1] = 20;
                numsArray1[2] = 30;
                numsArray1[3] = 40;
                numsArray1[4] = 50;

                //How to take array element from user
                int[] numsArray3 = new int[5];
                for (int i = 0; i < numsArray3.Length; i++)
                {
                    Console.Write("Enter Element for index {0}:", i);
                    numsArray3[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Array Elements are:");

                foreach (var temp in numsArray3)
                {
                    Console.Write("{0}\t",temp);
                }
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
