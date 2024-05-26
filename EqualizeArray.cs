using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class EqualizeArray
    {
        public EqualizeArray()
        {
            equalizeArray(new() { 3, 3, 2, 1, 3 });
            equalizeArray(new() { 3, 3, 2, 1, 3, 2, 2, 2, 2, 2, 2 });
            equalizeArray(new() { 10, 27, 9, 10, 100, 38, 30, 32, 45, 29, 27, 29, 32, 38, 32, 38, 14, 38, 29, 30, 63, 29, 63, 91, 54, 10, 63 });
        }

        private static int equalizeArray(List<int> arr)
        {
            Dictionary<int, int> numberCounts = new();

            foreach (int number in arr)
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
            var maxValueKey = numberCounts.FirstOrDefault(x => x.Value == numberCounts.Values.Max());
            int result = 0;
            foreach (var item in numberCounts)
            {
                if (item.Key != maxValueKey.Key)
                {
                    result += item.Value;
                }
            }
            return result;
        }
    }
}
