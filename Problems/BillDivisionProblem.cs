using System.Collections.Generic;

namespace HackerHank.Console.Problems
{
    public static class BillDivisionProblem
    {
        public static void BonAppetit(List<int> bill, int k, int b)
        {
            var sum = 0;
            for (int i = 0; i <= bill.Count - 1; i++)
                if (i != k) sum += bill[i];

            System.Console.WriteLine(
                (((sum / 2) - b < 0) ? 
                (((sum / 2) - b) * -1).ToString() : 
                "Bon Appetit"));
        }
    }
}
