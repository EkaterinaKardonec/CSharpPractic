using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int j = a.Length - 1;

            for (int i = 0; i <= a.Length / 2; i++)
            {
                if (i == j) 
                {
                    Console.WriteLine(a[i]);
                    break;
                }
                Console.WriteLine((a[i] * a[j]));
                j--;
            }

        }
    }
}
