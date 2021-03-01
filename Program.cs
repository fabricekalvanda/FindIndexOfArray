using System;

namespace FindIndexOfArray
{
    class Program
    {
        static int Balance(int[] arrayy, int x)
        {
            int i, j;
            int leftSum, rightSum;


            for (i = 0; i < x; ++i)
            {
                leftSum = 0;

                rightSum = 0;

                for (j = 0; j < i; j++)
                    leftSum += arrayy[j];

                for (j = i + 1; j < x; j++)
                    rightSum += arrayy[j];

                if (leftSum == rightSum)
                    return i;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] arrayy = { 2, 3, 5, 5, 2 };
            int arrayBalance = arrayy.Length;

            Console.Write(Balance(arrayy, arrayBalance));
        }
    }
}
