using System.Collections.Generic;

namespace HackerHank.Console.Problems
{
    public static class BreakingRecordsProblem
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            var result = new List<int>();
            var mostPoints = scores[0];
            var leastPoints = scores[0];
            var mostRecord = 0;
            var leastRecord = 0;

            for (int i = 1; i <= scores.Count - 1; i++)
            {
                if (scores[i] > mostPoints)
                {
                    mostPoints = scores[i];
                    mostRecord += 1;
                }
                if (scores[i] < leastPoints)
                {
                    leastPoints = scores[i];
                    leastRecord += 1;
                }
            }

            result.Add(mostRecord);
            result.Add(leastRecord);

            return result;
        }
    }
}
