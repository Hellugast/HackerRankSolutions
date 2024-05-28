using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class TaumBDay
    {
        public TaumBDay()
        {
            taumBDay(10, 10, 1, 1, 1);
            taumBDay(3, 6, 9, 1, 1);
            taumBDay(7, 7, 4, 2, 1);
            taumBDay(3, 3, 1, 9, 2);
            taumBDay(27984, 1402, 619246, 615589, 247954);
        }

        long taumBDay(long b, long w, long bc, long wc, long z) // fonksiyon parametreleri int olarak alıyordu değiştirdim
        {
            long result = 0;
            if (bc < wc)
            {
                result += bc * b;
                if (wc > bc + z) result += w * (bc + z);
                else result += wc * w;
            }
            else
            {
                result += wc * w;
                if (bc > wc + z) result += b * (wc + z);
                else result += bc * b;
            }
            return result;
        }
    }
}
