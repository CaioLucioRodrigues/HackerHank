using System.Linq;

namespace HackerHank.Console.Problems
{
    public static class EletronicsShopProblem
    {
        public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var maxValue = 0;
            var sum = 0;

            for (int i = 0; i <= keyboards.Count() - 1; i++)
            {
                for (int j = 0; j <= drives.Count() - 1; j++)
                {
                    sum = (keyboards[i] + drives[j]);
                    if ((sum > maxValue) && (sum <= b))
                        maxValue = sum;
                }
            }

            if (maxValue == 0) return -1;
            else return maxValue;
        }
    }
}
