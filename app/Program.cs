using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int honestCount = 0;

            Console.WriteLine("Сколько чисел вы хотите вывести?");

            int numberCount = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberCount];

            Console.Write("[");

            for (int i = 0; i < numberCount; i++)
            {
                array[i] = rand.Next(100, 999);
                Console.Write(array[i]);

                if (i != numberCount - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");

            for (int i = 0; i < numberCount; i++)
            {
                if (array[i] % 2 == 0)
                {
                    honestCount++;
                }

            }
            Console.WriteLine("Количество четных значений - " + honestCount);

        }
    }
}
