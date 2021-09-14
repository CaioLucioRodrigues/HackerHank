using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerHank.Console.Problems
{
    public class MinMaxSumProblem
    {
        public static void MinMaxSum(List<int> arr)
        {
            arr.Sort();
            var max = Convert.ToUInt64(arr.Skip(1).Take(4).Sum());
            var min = Convert.ToUInt64(arr.Take(4).Sum());
            System.Console.WriteLine($"{min} {max}");
        }
    }
}
