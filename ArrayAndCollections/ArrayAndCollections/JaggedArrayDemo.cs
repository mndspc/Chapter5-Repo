using System;

namespace ArrayAndCollections
{
    class JaggedArrayDemo
    {
        //  This program shows how to work with jagged array
        static void Main()
        {
            int[][] jaggedArray = new int[2][];
            //jaggedArray[0] = new int[3];
            //jaggedArray[1] = new int[2];

            jaggedArray[0] = new int[] { 11, 22,33};
            jaggedArray[1] = new int[] {44,55};

            for(int i = 0; i < 2; i++)
            {
                foreach(var temp in jaggedArray[i])
                {
                    Console.Write("{0}\t",temp);
                }
                Console.WriteLine();
            }

            int[][,] jaggedArray1 = new int[2][,]
            {
                new int[,]{{11,22},{5,7}},
                new int[,]{{55,66},{77,88}}
            };
            Console.ReadLine();
        }
    }
}
