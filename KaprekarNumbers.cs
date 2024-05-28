using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class KaprekarNumbers
    {
        public KaprekarNumbers()
        {
            kaprekarNumbers(1, 1);
            kaprekarNumbers(1, 10000);
            kaprekarNumbers(3, 5);
        }

        void kaprekarNumbers(int p, int q)
        {
            string result = string.Empty;

            for (int i = p; i <= q; i++)
            {
                if (i < 9 && p <= 1) // p <= 1 şartı eklenmezse hackerrank doğru sonuç veriyor, {3, 5} kontrolü yanlış sonuç veriyor
                {
                    i = 9;
                    result += "1 ";
                }
                if (q < 9) break;

                string numberSqr = Math.Pow(i, 2).ToString();
                int rightHalfNumber = int.Parse(numberSqr.Substring(numberSqr.Length / 2));
                int leftHalfNumber = int.Parse(numberSqr.Substring(0, numberSqr.Length / 2));

                if (leftHalfNumber + rightHalfNumber == i)
                {
                    result += i + " ";
                }
            }
            if (result == string.Empty) Console.WriteLine("INVALID RANGE");
            Console.WriteLine(result);
        }
    }
}
