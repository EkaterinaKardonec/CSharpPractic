using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("число является четным");
            }
            else
            {
                Console.WriteLine("число является нечетным");
            }
        }
    }
}
