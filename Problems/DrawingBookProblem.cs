using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerHank.Console.Problems
{
    public static class DrawingBookProblem
    {
        public static int FromEnd(int n, int p)
        {
            if ((n % 2 == 0) && (n - p == 1) && (p > 2)) return 1;
            if ((n - p <= 1) || (p == 1)) return 0;
            var fromStart = Math.Floor(p / 2d);
            var fromEnd = Math.Floor((n - p) / 2d);
            return Convert.ToInt32(Math.Min(fromStart, fromEnd));
        }
    }
}
