using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    // Problem : https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    
    class Hourglasses2D
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int heighestSum = 0;
            heighestSum = recursiveHourglassSumFinder(0, 0, arr);
            return heighestSum;
        }


        static int recursiveHourglassSumFinder(int rPtr, int cPtr, int[][] arr)
        {
            int lastHigh = 0;
            int nextCPointer = cPtr + 1;
            int nextRPointer = rPtr;

            if (rPtr > 3)
            {
                return 0;
            }

            if (cPtr == 3)
            {
                nextCPointer = 0;
                nextRPointer++;
            }

            lastHigh = recursiveHourglassSumFinder(nextRPointer, nextCPointer, arr);


            int currentSum = 0;
            for (int i = rPtr; i < rPtr + 3; i++)
            {
                if (i == rPtr + 1)
                {
                    currentSum += arr[i][cPtr + 1];
                    continue;
                }

                for (int j = cPtr; j < cPtr + 3; j++)
                {
                    currentSum += arr[i][j];
                }
            }

            if (currentSum > lastHigh || nextRPointer > 3)
            {
                lastHigh = currentSum;
            }

            return lastHigh;
        }

        void Main(string[] args)
        {

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                string readline = Console.ReadLine();
                arr[i] = Array.ConvertAll(readline.Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                Console.WriteLine(readline);
            }

            int result = hourglassSum(arr);

            Console.WriteLine("Max sum {0}", result);
           
        }
    }
}
