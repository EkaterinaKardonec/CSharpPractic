using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int sum = 0;

            Console.WriteLine("Сколько чисел вы хотите вывести?");

            int numberCount = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberCount];

            Console.Write("[");

            for (int i = 0; i < numberCount; i++)
            {
                array[i] = rand.Next(100);
                Console.Write(array[i]);

                if (i != numberCount - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");

            for (int k = 1; k < numberCount; k += 2)
            {
                sum = sum + array[k];
            }
            Console.WriteLine("Сумма значений - " + sum);

        }
    }
}
