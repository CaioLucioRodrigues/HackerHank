using System.Collections.Generic;
using System.Linq;

namespace HackerHank.Console.Problems
{
    public static class BirthdayCakeCandlesProblem
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            // Pego o max antes por performance
            int max = candles.Max();
            return candles.Where(c => c == max).Count();
        }
    }
}
