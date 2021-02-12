using System;

namespace HackerRank.WarmUpChallenges
{
    class RepeatedString
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {

            long occurenceOfa = 0;

            if (n == 0 || s.Length == 0)
            {
                return occurenceOfa;
            }

            int stringLength = s.Length;
            long stringOccurences = Math.Abs(n / stringLength);

            string tempString = new String(s.ToCharArray());
            int occurenceOfaPerString = tempString.Length - tempString.Replace("a", "").Length;

            occurenceOfa = stringOccurences * occurenceOfaPerString;


            long remainingCharacterLength = n - (stringOccurences * stringLength);

            for (int i = 0; i < remainingCharacterLength; i++)
            {
                if(s[i] == 'a')
                {
                    occurenceOfa++;
                }
            }


            return occurenceOfa;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine("Occurences of a : {0}", result);
        }
    }
}
