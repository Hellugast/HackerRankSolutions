using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class PickingNumbers
    {
        public PickingNumbers()
        {
            pickingNumbers(new List<int>() { 4, 6, 5, 3, 3, 1, 3, 2, 2, 1, 3, 4, 4, 2, 3, 4, 2, 1, 2, 3, 2, 2, 2, 1, 1, 2, 2 });
        }
        private int pickingNumbers(List<int> a)
        {
            Dictionary<int, int> numberCounts = new();

            foreach (int number in a)
            {
                if (!numberCounts.ContainsKey(number))
                {
                    numberCounts.Add(number, 1);
                }
                else if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++;
                }
            }

            int maxRepeatCount = 0;

            foreach (int numberKey in numberCounts.Keys)
            {
                if (numberCounts.ContainsKey(numberKey - 1) && maxRepeatCount < numberCounts[numberKey] + numberCounts[numberKey - 1])
                {
                    maxRepeatCount = numberCounts[numberKey] + numberCounts[numberKey - 1];
                }
                if (numberCounts.ContainsKey(numberKey + 1) && maxRepeatCount < numberCounts[numberKey] + numberCounts[numberKey + 1])
                {
                    maxRepeatCount = numberCounts[numberKey] + numberCounts[numberKey + 1];
                }
                if (numberCounts[numberKey] > maxRepeatCount)
                {
                    maxRepeatCount = numberCounts[numberKey];
                }
            }
            Console.WriteLine(maxRepeatCount);

            return maxRepeatCount;
        }
    }
}
