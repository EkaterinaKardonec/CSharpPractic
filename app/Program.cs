using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[,]
                {
                    {2,4},
                    {3,2}
                };
            int[,] matrix2 = new int[,]
                {
                    {3,4},
                    {3,3},
                };

            if (matrix1.GetLength(0) != matrix2.GetLength(1))
            {
                Console.WriteLine("произведение матриц не определено");
                return;
            }

            PrintResult(MultypliMatrix(matrix1, matrix2));
        }

        public static int[,] NewResultMatrix(int row, int column)
        {
            int[,] tmp = new int[row, column];

            for (int i = 0; i < tmp.GetLength(0); i++)
            {
                for (int j = 0; j < tmp.GetLength(1); j++)
                {
                    tmp[i, j] = 0;
                }
            }

            return tmp;
        }
        public static int[,] MultypliMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = NewResultMatrix(matrix1.GetLength(0), matrix2.GetLength(1));

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int g = 0; g < result.GetLength(1); g++)
                    {
                        result[i, j] += matrix1[i, g] * matrix2[g, j];
                    }
                }
            }

            return result;
        }

        public static void PrintResult(int[,] result)
        {
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(" " + result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
