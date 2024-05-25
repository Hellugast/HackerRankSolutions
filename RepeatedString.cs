using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class RepeatedString
    {
        public RepeatedString()
        {
            repeatedString("aba", 10);
        }


        public long repeatedString(string s, long n)
        {
            int howManyA = 0;
            foreach (var item in s)
            {
                if (item == 'a') howManyA++;
            }

            var result = (Math.Floor((double)(n / s.Length))) * howManyA;
            var remainingLetters = n % s.Length;
            for (int i = 0; i < remainingLetters; i++)
            {
                if (s[i] == 'a')
                    result++;
            }
            return (long)result;
        }

    }
}
