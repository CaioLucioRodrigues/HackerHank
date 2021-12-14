using System;

namespace HackerHank.Console.Problems
{
    public static class CatAndMouseProblem
    {
        public static string CatAndMouse(int x, int y, int z)
        {
            return Math.Abs(x - z) > Math.Abs(y - z) ? "Cat B" :
                   Math.Abs(x - z) < Math.Abs(y - z) ? "Cat A" : 
                   "Mouse C";
        }
    }
}
