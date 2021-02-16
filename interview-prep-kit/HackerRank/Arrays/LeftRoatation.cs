using System;

namespace HackerRank.Arrays
{
    class LeftRoatation
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] leftRotatedIndex = new int[a.Length];
            int size = 0;

            for (int i = d; i < a.Length; i++)
            {
                leftRotatedIndex[size] = a[i];
                size++;
            }

            for (int i = 0; i < d; i++)
            {
                leftRotatedIndex[size] = a[i];
                size++;
            }

            return leftRotatedIndex;

        }

        void Main(string[] args)
        {

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = rotLeft(a, d);

        }
    }
}
