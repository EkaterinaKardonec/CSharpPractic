using System;
using System.Linq;


namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координы 1 точки в формате x;y;z");
                    
            string[] strVals = Console.ReadLine().Split(';');
            int[] t1 = new int[strVals.Length];
            for(int i =0; i < strVals.Length; i++)
            {
                t1[i] = Convert.ToInt32(strVals[i]);
            }

            Console.WriteLine("Введите координы 2 точки в формате x;y;z");

            string[] strVals1 = Console.ReadLine().Split(';');
            int[] t2 = new int[strVals1.Length];
            for (int i = 0; i < strVals1.Length; i++)
            {
                t2[i] = Convert.ToInt32(strVals1[i]);
            }

            Console.WriteLine(Math.Sqrt(Math.Pow(t2[0] - t1[0], 2) + Math.Pow(t2[1] - t1[1], 2) + Math.Pow(t2[2] - t1[2], 2)));
        }
    }
}
