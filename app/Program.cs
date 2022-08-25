using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] resultArray = { 0, 0, 0, 0 };
            int[] countArray = { 0, 0, 0, 0 };
            double[,] myArray = new double[,]
            {
              {1,4,7,2},
              {5,9,2,3},
              {8,4,2,4}
            };

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(" " + $"{myArray[i, j]}");
                    resultArray[j] += myArray[i, j];
                    countArray[j]++;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < resultArray.Length; i++)
            {
                double result = resultArray[i] / countArray[i];

                Console.Write(" " + result);
            }
        }
    }
}
