using System;
using System.Collections.Generic;

namespace HackerHank.Console.Problems
{
    public static class GradingStudentsProblem
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            var result = new List<int>();
            grades.ForEach(g => result.Add(g < 38 || g % 5 < 3 ? g : g + (5 - (g % 5))));
            return result;
        }
    }
}
