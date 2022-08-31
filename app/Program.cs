using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resultArray = { 0, 0, 0, 0 };
            int min = 0;
            int strNum = 0;
            int[,] myArray = new int[,]
                {
                    {1,4,7,2},
                    {5,9,2,3},
                    {8,4,2,4},
                    {5,2,6,7}
                };
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(" " + $"{myArray[i, j]}");
                    resultArray[i] += myArray[i, j];

                }
                Console.WriteLine();
            }
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(" " + resultArray[i]);
            }
            min = resultArray[0];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {

                if (resultArray[i] < min)
                {
                    min = resultArray[i];
                    strNum = i;
                }
            }
            Console.WriteLine();
            Console.Write("Номер строки с min значением "+strNum);
        }
    }
}

