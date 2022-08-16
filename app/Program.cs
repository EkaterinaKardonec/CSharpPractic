using System;

namespace app
{
    class Program
    {
        static void ReadNumber(int number)
        {
            Console.WriteLine(number * number);
        }
        static string WriteNumber(int number)
        {
            return number %% 2 == 0 ? "Кратное" : "Не кратное";
        }
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine())
            ReadNumber(number);
            Console.WriteLine(WriteNumber(number));
            
            Console.ReadLine();
        }
    }
}
