using System;
using System.Collections.Generic;

namespace HackerHank.Console.Problems
{
    public static class PickingNumberProblem
    {
        public static int PickingNumbers(List<int> a)
        {
            var length = 0;
            var maxLegth = 0;
            var mainValue = -1;
            a.Sort();

            for (int i = 0; i <= a.Count - 1; i++)
            {
                if (i == 0) mainValue = a[i];

                if (Math.Abs(mainValue - a[i]) <= 1)
                    length++;
                else
                {
                    mainValue = a[i];
                    length = 1;
                }

                if (length > maxLegth)
                    maxLegth = length;
            }

            return maxLegth;
        }
    }
}
