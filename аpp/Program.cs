using System;

namespace аpp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Введите целое число a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число c");
            c = Convert.ToInt32(Console.ReadLine());

            int max = a;

            if (a > max)
            {
                max = a;
            }

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine("max = " + max);
        }
    }
}
