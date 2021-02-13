using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.WarmUpChallenges
{
    class Result
    {

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int totalValleys = 0;

            int seaLevel = 0;
            bool intoTheValley = false;

            for (int i = 0; i < steps; i++)
            {

                if(path[i] == 'U')
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }

                if (seaLevel < 0)
                {
                    intoTheValley = true;
                }

                if (seaLevel == 0 && intoTheValley)
                {
                    totalValleys++;
                    intoTheValley = false;
                }
            }

            return totalValleys;
        }

    }

    class CountingValleys
    {
        public void Main(string[] args)
        {
           

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Result.countingValleys(steps, path);

            Console.WriteLine("Total valleys seens : {0}", result);
        }
    }

}
