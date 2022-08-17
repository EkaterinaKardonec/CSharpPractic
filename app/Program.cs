using System;

namespace app
{
    class Program
    {
        static int PowTwoNumber(int number)
        {
            return number * number;
        }
        static string MultipleTwoNumber(int number) // Получение кратного /не кратного
        {
            return number % 2 == 0 ? "Кратное" : "Не кратное";
        }

        static int[] Shuffle(int[] array) // Получение рандомного списка чисел
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = new Random().Next(0, i + 1);
                int tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
            return array;

        }
        static int[] CreaterArray(int number)
        {
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
            
        }
        static void WriteArray(int[] array)
        {
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
        }

        public static void Main(string[] args)
        {
            /*int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PowTwoNumber(number));
            Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));*/
            int[] array = CreaterArray(30);
            WriteArray(array); //Вывод массива поочередно
            WriteArray(Shuffle(array)); //Вывод массива рандомно



            Console.ReadLine();
        }
    }
}
