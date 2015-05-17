using System;
using System.Collections.Generic;
using AlgorithmExamples.Sorting;

namespace AlgorithmExamples
{
    public static class AlgorithmHelper
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        public static T Max<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) > 0) ? x : y;
        }

        public static T Min<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) < 0) ? x : y;
        }
    }
}
