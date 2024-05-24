using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class SherlockAndSquares
    {
        public SherlockAndSquares()
        {
            squares(24, 49);
            squares(3, 9);
            squares(17, 24);
        }

        static int squares(int a, int b)
        {
            double minNumber = Math.Ceiling(Math.Sqrt(a));
            double maxNumber = Math.Floor(Math.Sqrt(b));
            return (int)(maxNumber - minNumber) + 1;
        }
    }
}
