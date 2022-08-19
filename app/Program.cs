using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double min = 0, max = 0;

            Console.WriteLine("Сколько чисел вы хотите вывести?");

            int numberCount = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[numberCount];

            Console.Write("[");

            for (int i = 0; i < numberCount; i++)
            {
                array[i] = rand.NextDouble();

                if (0 == i)
                {
                    min = array[i];
                    max = array[i];
                }

                Console.Write(array[i]);

                if (i != numberCount - 1)
                {
                    Console.Write(", ");
                }

                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("]");
            Console.WriteLine("Разница между max и min " + (max - min));
        }
    }
}
