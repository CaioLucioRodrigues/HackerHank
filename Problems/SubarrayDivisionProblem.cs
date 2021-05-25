using System.Collections.Generic;

namespace HackerHank.Console.Problems
{
    public static class SubarrayDivisionProblem
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            int result = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                int count = 0;
                for (int j = i; j < m + i; j++)
                {
                    count += s[j];
                }
                if (count == d)
                    result++;
            }

            return result;
        }
    }
}
