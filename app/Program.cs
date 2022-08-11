using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string a = Console.ReadLine();
            int i = 0, j = a.Length - 1;

            while (i != a.Length / 2)
            {
                if (a[i] != a[j])
                {
                    Console.WriteLine("Введеное число - НЕ палиндром");
                    Environment.Exit(0);
                }

                i++;
                j--;
            }

            Console.WriteLine("Введеное число - палиндром");
        }
    }
}
