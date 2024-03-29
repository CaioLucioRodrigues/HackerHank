﻿using HackerHank.Console.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace HackerHank.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(PickingNumberProblem.PickingNumbers(new List<int>() { 4, 6, 5, 3, 3, 1 })); 
        }

        #region PickingNumbers
        private static void PickingNumbers()
        {
            var min = PickingNumbersProblem.MinSequence(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
            var max = PickingNumbersProblem.MaxSequence(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
            WriteLine($"{min} {max}");
        }
        #endregion

        #region DivisibleSumPairs
        private static void DivisibleSumPairs()
        {
            var resultado = DivisibleSumPairsProblem.DivisibleSumPairs(6, 3, new List<int>() { 1, 3, 2, 6, 1, 2 });
            WriteLine(resultado.ToString());
        }
        #endregion

        #region SubarrayDivision
        private static void SubarrayDivision()
        {
            var result = SubarrayDivisionProblem.Birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2);
            WriteLine(result.ToString());
        }
        #endregion

        #region BreakingRecords
        private static void BreakingRecords()
        {
            BreakingRecordsProblem.BreakingRecords(new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 })
                .ForEach(e => WriteLine(e.ToString()));
        }
        #endregion

        #region NumberLineJumps
        private static void NumberLineJumps()
        {
            WriteLine(NumberLineJumpsProblem.Kangaroo(0, 3, 4, 2));
            WriteLine(NumberLineJumpsProblem.Kangaroo(0, 2, 5, 3));
            WriteLine(NumberLineJumpsProblem.Kangaroo(21, 6, 47, 3));
        }
        #endregion

        #region GradingStudents
        private static void GradingStudents()
        {
            var result = GradingStudentsProblem.GradingStudents(
                new List<int> { 73, 67, 38, 33 });

            result.ForEach(i => WriteLine(i.ToString()));
        }
        #endregion

        #region TimeConversion
        private static void TimeConversion()
        {
            WriteLine(TimeConversionProblem.TimeConversion("06:40:03AM"));
        }
        #endregion

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







