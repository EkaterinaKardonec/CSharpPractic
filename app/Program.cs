using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Введите числа");
                string a = Console.ReadLine();

                int r = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    r = r + Convert.ToInt32(a[i].ToString());
                }

                Console.WriteLine(r);
            }
        }
    }
}
