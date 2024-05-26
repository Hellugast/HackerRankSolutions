using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class JumpingOnClouds
    {
        public JumpingOnClouds()
        {
            //jumpingOnClouds(new() { 0, 0, 1, 0, 0, 1, 0 });
            jumpingOnClouds(new() { 0, 0, 0, 1, 0, 0 });
        }

        int jumpingOnClouds(List<int> c)
        {
            int result = 0;
            int i = 0;
            while (true)
            {
                if (i + 1 >= c.Count) break;
                if (i + 2 < c.Count && c[i + 2] != 1) i += 2;
                else i++;
                result++;
            }
            return result;
        }
    }
}
