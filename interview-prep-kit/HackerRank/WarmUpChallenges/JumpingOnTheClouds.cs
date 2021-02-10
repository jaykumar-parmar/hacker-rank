using System;
using System.IO;

namespace HackerRank.WarmUpChallenges
{
    class JumpingOnTheClouds
    {
        static int jumpingOnClouds(int[] c)
        {
            int steps = 0;
            int ptr = 0;

            while (ptr < c.Length)
            {
                int supeJumpPtr = ptr + 2;

                if (supeJumpPtr < c.Length)
                {
                    int superJump = c[supeJumpPtr];
                    if (superJump == 0)
                    {
                        ptr += 2;
                        steps++;
                        continue;
                    }
                }

                ptr += 1;
                steps++;
            }

            return steps - 1;

        }


        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine("Total Steps {0}", result);
            Console.ReadKey();
        }
    }
}
