using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4;
            string[,] myArray = new string[N, N];

            int pos = 0;
            int count = N;
            int value = -N;
            int sum = -1;

            do
            {
                value = -1 * value / N;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    pos++;
                    if (pos < 10) {
                        myArray[sum / N, sum % N] ="0"+pos.ToString();
                    } else
                    {
                        myArray[sum / N, sum % N] = pos.ToString();
                    }
                }

                value *= N;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    pos++;
                    if (pos < 10)
                    {
                        myArray[sum / N, sum % N] = "0" + pos.ToString();
                    }
                    else
                    {
                        myArray[sum / N, sum % N] = pos.ToString();
                    }
                }
            } while (count > 0);


            int n = (myArray.GetLength(0) * myArray.GetLength(1) - 1).ToString().Length + 1;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {         
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j].PadLeft(n, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
