using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class FindDigits
    {
        public FindDigits()
        {
            findDigits(1012);
            findDigits(1012112);
        }

        int findDigits(int n)
        {
            int result = 0;
            int divider = 10;

            while (true)
            {
                if ((n * 10 / divider) > 0)
                {
                    if ((n * 10 / divider) % 10 == 0)
                    {
                        divider *= 10;
                        continue;
                    }
                    if (n % ((n * 10 / divider) % 10) == 0) result++;

                    divider *= 10;
                }
                else
                    break;
            }
            return result;
        }
    }
}
