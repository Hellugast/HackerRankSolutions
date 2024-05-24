using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class LibraryFine
    {
        public LibraryFine()
        {
            libraryFine(9, 6, 2015, 6, 6, 2015);
            libraryFine(2, 7, 2014, 1, 1, 2015);
        }

        int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if (y2 < y1) return 10000;
            else if (m2 < m1 && y2 <= y1) return (m1 - m2) * 500;
            else if (d2 < d1 && y2 <= y1 && m2 <= m1) return (d1 - d2) * 15;
            else return 0;
        }
    }
}
