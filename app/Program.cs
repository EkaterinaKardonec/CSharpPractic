using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[][]
          {
                 new int[]{1,4,7,2},
                 new int[]{5,9,2,3},
                 new int[]{8,4,2,4}
          };
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                myArray[i] = BubleSort(myArray[i]);
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray[i].GetLength(0); j++)
                {
                    Console.Write(myArray[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static int[] BubleSort(int[] myArray)
        {
            for (int j = 0; j < myArray.GetLength(0); j++)
            {
                for (int g = j + 1; g < myArray.GetLength(0); g++)
                {
                    if (myArray[j] < myArray[g])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[g];
                        myArray[g] = temp;
                    }
                }
            }
            return myArray;
        }
    }
}

