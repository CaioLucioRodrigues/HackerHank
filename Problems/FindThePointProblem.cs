namespace HackerHank.Console.Problems
{
    public static class FindThePointProblem
    {
        //0 0 1 1 -> 2 2
        //1 1 2 2 -> 3 3
        public static int[] FindPoint(int px, int py, int qx, int qy)
        {
            return new int[] { (2 * qx - px), (2 * qy - py) };            
        }
    }
}
