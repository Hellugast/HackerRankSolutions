using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class AppendAndDelete
    {

        public AppendAndDelete()
        {
            appendAndDelete("hacker", "ba", 5);
        }
        private string appendAndDelete(string s, string t, int k)
        {
            string shorterString;
            if (s.Length > t.Length)
            {
                shorterString = t;
            }
            else
            {
                shorterString = s;
            }
            int sameCharCount = 0;
            for (int i = 0; i < shorterString.Length; i++)
            {
                if (s[i] == t[i]) sameCharCount++;
                if (s[i] != t[i]) break;

            }

            var remainingS = s.Length - sameCharCount;
            var remainingT = t.Length - sameCharCount;

            if ((k - (s.Length + t.Length) >= 0)) return "Yes";

            if ((k - (remainingS + remainingT)) >= 0 && (k - (remainingS + remainingT)) % 2 == 0)
            {
                return "Yes";
            }
            if (s == t && k % 2 == 0)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
