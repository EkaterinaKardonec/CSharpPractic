using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[3, 4];

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = random.NextDouble();
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}