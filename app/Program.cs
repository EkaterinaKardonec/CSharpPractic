using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int m=2, n=3;
            Console.WriteLine(Akkerman(n,m));
        }


        static int Akkerman(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }

            if (n > 0 && m == 0)
            {
                return Akkerman(n - 1, 1);
            }

            if (n > 0 && m > 0)
            {
                return Akkerman(n - 1, Akkerman(n, m - 1));
            }

            return Akkerman(n,m);
        }
    }
}
