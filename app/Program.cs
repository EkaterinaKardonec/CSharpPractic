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
            bool flag = true;


            while (i != a.Length / 2)
            {
                if (a[i] != a[j])
                {
                    flag = false;
                    break;
                }

                i++;
                j--;
            }

            if (flag == true)
            {
                Console.WriteLine("Введеное число - палиндром");
            }
            else
            {
                Console.WriteLine("Введеное число - НЕ палиндром");
            }


        }
    }
}
