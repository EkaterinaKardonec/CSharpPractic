using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели ");

            var a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.Write("это будний день");
                    break;
                case 6:
                case 7:
                    Console.Write("это выходной день");
                    break;
                default:
                    Console.Write("Это не день недели");
                    break;
            }

        }
    }
}
