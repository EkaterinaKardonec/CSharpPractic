using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифры ");

            var a = Console.ReadLine();
            if (a.Length<3) 
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else
            {
                Console.WriteLine(a[2]);
            }        
        }

    }

}

