using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] a = new int[123];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(999);
                if (a[i] >= 10 && a[i] <= 99)
                {
                    count++;
                }

                Console.Write(a[i]);
                if (i != a.Length - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Элементов в [10; 99]" + count);
        }
    }
}
