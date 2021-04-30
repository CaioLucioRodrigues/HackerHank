﻿using HackerHank.Console.Problems;
using System;
using System.Collections.Generic;
using static System.Console;

namespace HackerHank.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }



        #region AppleAndOrange
        private static void AppleAndOrange()
        {
            AppleAndOrangeProblem.CountApplesAndOranges(2, 3, 1, 5, new List<int>() { 2 }, new List<int>() { -2 });
        }
        #endregion

        #region BirthdayCakeCandles
        private static void BirthdayCakeCandles()
        {
            int total = BirthdayCakeCandlesProblem.BirthdayCakeCandles(new List<int> { 3, 2, 1, 3 });
            WriteLine("3, 2, 1, 3");
            WriteLine(total.ToString());
            WriteLine("");
        }
        #endregion

        #region FindThePoint
        private static void FindThePoint()
        {
            var result = FindThePointProblem.FindPoint(0, 0, 1, 1);
            WriteLine("0, 0, 1, 1");
            ImprimirFindThePoint(result);

            result = FindThePointProblem.FindPoint(1, 1, 2, 2);
            WriteLine("1, 1, 2, 2");
            ImprimirFindThePoint(result);

            result = FindThePointProblem.FindPoint(7, 8, 9, 1);
            WriteLine("7, 8, 9, 1");
            ImprimirFindThePoint(result);
        }

        private static void ImprimirFindThePoint(int[] result)
        {
            Write($"{result[0].ToString()} {result[1].ToString()}");
            WriteLine("");
        }
        #endregion
    }
}
