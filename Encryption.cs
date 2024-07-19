using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class Encryption
    {
        public Encryption()
        {
            encryption("haveaniceday");
            encryption("feedthedog");
            encryption("feedthedog");
            encryption("chillout");
        }

        public string encryption(string s)
        {
            StringBuilder result = new StringBuilder();
            s = s.Replace(" ", "");
            int n = s.Length;
            int row = (int)Math.Sqrt(n);
            int column = (row * row == n) ? row : row + 1;

            for (int i = 0; i < column; i++)
            {
                for (int j = i; j < n; j += column)
                {
                    result.Append(s[j]);
                }
                result.Append(" ");
            }
            return result.ToString();
        }
    }
}
