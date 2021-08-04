using System;

namespace HackerHank.Console.Problems
{
    public class DayOfTheProgrammerProblem
    {
        public static string DayOfProgrammer(int year)
        {   
            string dt = DateTime.MinValue.ToString();
            string style = year != 1918 ? "Not 1918" : "1918";

            switch (style)
            {
                case "Not 1918":
                    dt = year < 1918 ?
                    year % 4 > 0 ?
                        $"13.09.{year}" : $"12.09.{year}" :
                    year % 400 == 0 || (year % 4 == 0 && year % 100 > 0) ?
                        $"12.09.{year}" : $"13.09.{year}";
                    break;

                case "1918":
                    dt = $"26.09.1918";
                    break;
            }

            return dt;
        }
    }
}
