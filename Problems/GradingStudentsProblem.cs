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
            
            //var result = new List<int>();
            //grades.ForEach(g =>
            //{
            //    if (g < 38) result.Add(g);
            //    else
            //    {
            //        if ((((Math.Ceiling(g / 5m)) * 5) - g) < 3)
            //            result.Add(Convert.ToInt32(Math.Ceiling(g / 5m)) * 5);
            //        else
            //            result.Add(g);
            //    }
            //});        
            return result;
        }
    }
}
