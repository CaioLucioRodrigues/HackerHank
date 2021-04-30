using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace HackerHank.Console.Problems
{
    public static class AppleAndOrangeProblem
    {
        //s: starting point of Sam's house location.
        //t: ending location of Sam's house location.
        //a: location of the Apple tree.
        //b: location of the Orange tree.
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {         
            var applesInHouse = 0;
            var orangesInHouse = 0;

            applesInHouse = apples.Count(apple => apple + a >= s && apple + a <= t);
            orangesInHouse = oranges.Count(orange => orange + b >= s && orange + b <= t);

            WriteLine(applesInHouse.ToString());
            WriteLine(orangesInHouse.ToString());
        }
    }
}
