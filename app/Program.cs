using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа через запятую");

            string[] strVals = Console.ReadLine().Split(',');
            int[] t = new int[strVals.Length];
            for (int i = 0; i < strVals.Length; i++)
            {
                t[i] = Convert.ToInt32(strVals[i]);
            }
            
            int r = 1;

            for (int i = 0; i < t[1]; i++)
            {
                r *= t[0];
            }

            Console.WriteLine(r);
        }
    }
}
