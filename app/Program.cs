using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double[,] myArray = new double[,]
            {
              {1,4,7,2},
              {5,9,2,3},
              {8,4,2,4}
            };

            for (int i = 0; i < myArray.GetLength(1); i++)
            {
                result = 0;

                for (int j = 0; j < myArray.GetLength(0); j++)
                {
                    result += myArray[j, i];
                }

                Console.WriteLine($"Среднее арифметическое столбца {i}: " + result / myArray.GetLength(0));
            }
        }
    }
}
