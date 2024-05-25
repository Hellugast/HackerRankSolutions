using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class CutTheSticks
    {
        public CutTheSticks()
        {
            cutTheSticks(new() { 5, 4, 4, 2, 2, 8 });
            cutTheSticks(new() { 5, 4, 2, 8, 8 });
        }

        private List<int> cutTheSticks(List<int> arr)
        {
            var lastArray = new List<int>(arr);
            var cuttedArray = new List<int>();
            var result = new List<int>() { arr.Count };
            while (true)
            {
                var shortestStick = lastArray.Min(x => x);
                foreach (var stick in lastArray)
                {
                    if (stick - shortestStick > 0) cuttedArray.Add(stick - shortestStick);
                }
                if (cuttedArray.Count == 0) break;  // !!!!
                result.Add(cuttedArray.Count);
                lastArray = new List<int>(cuttedArray);
                if (lastArray.Count == 1) break;    // !!!!
                cuttedArray.Clear();
            }
            return result;
        }
    }
    // SHOULD BE OPTIMIZED !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
}
