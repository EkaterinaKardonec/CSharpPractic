using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 4]
          {
                 {1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4}
          };
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int g = j + 1; g < myArray.GetLength(1); g++)
                    {
                        if (myArray[i, j] < myArray[i, g])
                        {
                            int temp = myArray[i, j];
                            myArray[i, j] = myArray[i, g];
                            myArray[i, g] = temp;
                        }
                    }
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

