namespace HackerHank.Console.Problems
{
    public static class CountingValleysProblemn
    {
        public static int CountingValleys(int steps, string path)
        {
            var valleys = 0;
            var elevation = 0;
            var inValley = false;            

            for (int i = 0; i < path.Length; i++)
            {
                elevation += ((path[i] == 'D') ? -1 : 1);
                
                if (elevation < 0)
                    inValley = true;

                if ((inValley) && (elevation == 0))
                {
                    inValley = false;
                    ++valleys;
                }
            }
            return valleys;
        }
    }
}
