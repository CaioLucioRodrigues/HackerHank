using System.Collections.Generic;

namespace HackerHank.Console.Problems
{
    public static class DivisibleSumPairsProblem
    {       
        public static int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            var pares = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0) pares++;
                }
            }
            return pares;
        }
    }
}
