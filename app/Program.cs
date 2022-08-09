using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели ");

            var a = Convert.ToInt32(Console.ReadLine());

            if (a>=1 && a<=5)
            {
                Console.Write("это будний день");
            }
            else if (a >= 6 && a <= 7)
            {
                Console.Write("это выходной день");
            }
            else
            {
                Console.Write("Это не день недели");
            }
        }
    }
}
