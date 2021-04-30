using System;
using System.Text.RegularExpressions;

namespace HackerHank.Console.Problems
{
    public static class TimeConversionProblem
    {
        // input 07:05:45PM
        // output 19:05:45
        public static string TimeConversion(string s)
        {
            var militaryTime = string.Empty;
            var morningOrAfternoon = Regex.Replace(s, "[^a-zA-Z]", "");
            var hour = Convert.ToInt32(s.Substring(0, 2));

            if (morningOrAfternoon == "AM")
            {
                if (hour == 12)
                    militaryTime = "00";
                else
                    militaryTime = hour.ToString().PadLeft(2, '0');
            }
            else
            {
                if (hour == 12)
                    militaryTime = "12";
                else
                    militaryTime = (hour + 12).ToString();
            }

            militaryTime += s.Substring(2, 6);
            return militaryTime;        
        }
    }
}
