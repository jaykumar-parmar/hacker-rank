using System;
using System.Linq;

namespace HackerRank.Arrays
{
    class NewYearChaos
    {

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int bribes = 0;
            bool isChaotic = false;

            int[] originalarray = Enumerable.Range(1, q.Length).ToArray();

            for (int i = 1; i <= q.Length; i++)
            {
                int index = i - 1;
                int value = q[index];


                if (value != originalarray[index])
                {
                    int originalIndex = findIndex(index, value, value, originalarray);
                    int bribeCount = originalIndex - index;

                    if (bribeCount > 2)
                    {
                        isChaotic = true;
                        break;
                    }

                    int temp;
                    if (bribeCount > 1)
                    {
                        temp = originalarray[index];
                        originalarray[index] = originalarray[index + 1];
                        originalarray[index + 1] = temp;
                    }

                    temp = originalarray[index];
                    originalarray[index] = value;
                    originalarray[index + bribeCount] = temp;
                    bribes += bribeCount;

                }
            }

            if (isChaotic)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(bribes);
            }
        }

        static int findIndex(int start, int end, int value, int[] ar)
        {
            for (int i = start; i < ar.Length; i++)
            {
                if (ar[i] == value)
                    return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }
    }
}
