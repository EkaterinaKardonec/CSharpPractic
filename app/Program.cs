using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}

