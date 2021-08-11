using System.Collections.Generic;
using System.Linq;

namespace HackerHank.Console.Problems
{
    public static class MigratoryBirdsProblem
    {
        public static int MigratoryBirds(List<int> arr)
        {
            var counts = new Dictionary<int, int>();
            var maxs = new List<int>();

            for (int i = 0; i <= arr.Count - 1; i++)
            {
                if (counts.ContainsKey(arr[i]))
                    counts[arr[i]] += 1;
                else
                    counts[arr[i]] = 1;
            }

            int maxValue = 0;
            for (int i = 0; i <= counts.Count - 1; i++)
            {
                if (counts.ElementAt(i).Value > maxValue)
                {
                    maxs.Clear();
                    maxValue = counts.ElementAt(i).Value;
                    maxs.Add(counts.ElementAt(i).Key);
                }
                else if (counts.ElementAt(i).Value == maxValue)
                    maxs.Add(counts.ElementAt(i).Key);
            }
            return maxs.Min();
        }
    }
}
