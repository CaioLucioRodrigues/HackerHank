using System.Collections.Generic;
using System.Linq;

namespace HackerHank.Console.Problems
{
    public static class PickingNumbersProblem
    {
        public static int MaxSequence(List<int> a)
        {
            a.Sort();      
            return (a.Sum() - a.Min());
        }

        public static int MinSequence(List<int> a)
        {
            a.Sort();
            return (a.Sum() - a.Max());
        }
    }
}