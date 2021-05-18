using System.Collections.Generic;
using System.Linq;

namespace HackerHank.Console.Problems
{
    public static class FormingMagicSquareProblem
    {
        public static int FormingMagicSquare(List<List<int>> s)
        {
            var integers = new List<int>();
            s.ForEach(i => integers.AddRange(i));

            integers = integers.OrderBy(i => i).ToList();

            return 0;
        }
    }
}
