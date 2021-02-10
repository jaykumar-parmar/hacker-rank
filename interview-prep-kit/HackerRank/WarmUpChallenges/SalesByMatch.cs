using System;
using System.Collections;

namespace HackerRank.WarmUpChallenges
{
    class SalesByMatch
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;

            if (n <= 1)
            {
                return pairs;
            }

            ArrayList pairedSocks = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                int sock = ar[i];

                for (int j = i + 1; j < n; j++)
                {
                    if (pairedSocks.Contains(j))
                    {
                        continue;
                    }

                    if (sock == ar[j] && !pairedSocks.Contains(j))
                    {
                        pairedSocks.Add(i);
                        pairedSocks.Add(j);
                        pairs++;
                        break;
                    }
                }
            }

            return pairs;

        }

        void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);

            Console.WriteLine("Pairs {0}", result);
            Console.ReadKey();

        }
    }
}
