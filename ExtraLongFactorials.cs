using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class ExtraLongFactorials
    {
        public ExtraLongFactorials()
        {
            extraLongFactorials(30);
        }

        private void extraLongFactorials(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

        //easy way
    }
}
