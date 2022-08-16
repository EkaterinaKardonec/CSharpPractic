using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputArray(InputArray());
        }

        private static int[] InputArray()
        {
            Console.WriteLine("Введите числа через запятую ");

            string[] strVals = Console.ReadLine().Split(',');
            int[] t = new int[strVals.Length];

            for (int i = 0; i < strVals.Length; i++)
            {
                t[i] = Convert.ToInt32(strVals[i]);
            }

            return t;
        }

        private static void OutputArray(int[] a)
        {
            Console.Write("[");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);

                if (i != a.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("]");
        }
    }
}
