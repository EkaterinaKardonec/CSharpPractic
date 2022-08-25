using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 4]
            {
                {1,4,7,2},
                {5,9,2,3},
                {8,4,2,4}
            };

            Console.WriteLine("Введите координы через запятую");

            string[] strVals = Console.ReadLine().Split(',');
            int[] position = new int[strVals.Length];
            for (int i = 0; i < strVals.Length; i++)
            {
                position[i] = Convert.ToInt32(strVals[i]);
            }

            if (position[0] < myArray.GetLength(0) && position[1] < myArray.GetLength(1))
            {
                Console.WriteLine(myArray[position[0], position[1]]);
            }
            else
            {
                Console.WriteLine("Введенные координты находятся за пределами массива.");
            }


        }
    }
}
