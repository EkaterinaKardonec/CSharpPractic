using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Введите целое число a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число b");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("max = " + a);
            }
            else
            {
                Console.WriteLine("max = " + b);
            }
        }
    }
}
