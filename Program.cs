using System;

namespace FindIndexOfArray
{
    class Program
    {
        /*
        static int Balance(int[] arrayy, int x)
        {
            int i, j;
            int leftSum, rightSum;

            //Loop until the balance index is found 
            for (i = 0; i < x; i++)
            {
                //initialize the left sum
                leftSum = 0;

                //initialized the right sum
                rightSum = 0;

                //get the left sum
                for (j = 0; j < i; j++)
                    leftSum += arrayy[j];

                //get the right sum
                for (j = i + 1; j < x; j++)
                    rightSum += arrayy[j];

                //check if the left sum is equal the right sum, then retun the index
                if (leftSum == rightSum)
                    return i;
            }

            //if the balance index is not found, then return -1
            return -1;


        } */

        static int Balance(int[] arrayy, int x)
        {
            // initialize the sum the entire array
            int sum = 0;

            // initialize the leftsum
            int leftsum = 0;

            /* get the sum of the entire array */
            for (int i = 0; i < x; i++)
                sum += arrayy[i];

            for (int i = 0; i < x; i++)
            {
                // the sum is right sum for the index i
                sum -= arrayy[i];

                if (leftsum == sum)
                    return i;

                leftsum += arrayy[i];
            }

            //if the balance index is not found, then return -1
            return -1;
        }

        // the main method
        static void Main(string[] args)
        {
            int[] arrayy = { 16, 8, 2, 4, 4, 6 };
            int arrayBalance = arrayy.Length;

            Console.Write(Balance(arrayy, arrayBalance));
        }
    }
}
