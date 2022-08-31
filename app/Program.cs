using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,,] myArray = new int[2, 2, 2];

            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int g = 0; g < myArray.GetLength(2); g++)
                    {
                        myArray[i, j, g] = random.Next(10, 99);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(2); i++)
            {
                for (int j = 0; j < myArray.GetLength(0); j++)
                {
                    for (int g = 0; g < myArray.GetLength(1); g++)
                    {
                        Console.Write(" " + myArray[j, g, i] +(j, g, i));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
