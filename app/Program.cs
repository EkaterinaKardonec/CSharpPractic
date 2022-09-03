using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, Sum=0;

            Console.WriteLine("Введите 1 число");
            M = Convert.ToInt32(Console.ReadLine());

            if (M <= 0)
            {
                Console.WriteLine("натуральные числа начинаются с 1");
                return;
            }

            Console.WriteLine("Введите 2 число");
            N = Convert.ToInt32(Console.ReadLine());
                        
            for (int i = M; i <= N; i++)
            {
                Sum = i + Sum;
            }

            Console.Write(Sum);
        }
    }
}
