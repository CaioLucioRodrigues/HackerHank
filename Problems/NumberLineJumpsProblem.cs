namespace HackerHank.Console.Problems
{
    public static class NumberLineJumpsProblem
    {   
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 == v2) return "NO";
            var result = (double)(x2 - x1) / (double)(v2 - v1);
            if (result % 1 != 0) return "NO";
            if (result > 0) return "NO";
            return "YES";
        }
    }
}
