using System;
using System.Collections.Generic;

namespace AlgorithmExamples.Sorting
{
    public abstract class ComparisonBasedAlgorithm<T> : IComparisonBasedSortAlgorithm<T>
        where T : IComparable<T>
    {
        public abstract IEnumerable<T> Sort(IReadOnlyList<T> input, SortDirection sortDirection);

        protected bool IsFirstBiggerThanSecond(T first, T second)
        {
            // null handling.
            if (first == null && second == null) return false;
            if (first == null) return false;
            if (second == null) return true;

            var result = first.CompareTo(second);
            return result > 0;
        }

        protected bool IsSecondBiggerThanFirst(T first, T second)
        {
            if (first == null && second == null) return false;
            if (first == null) return true;
            if (second == null) return false;

            var result = first.CompareTo(second);
            return result < 0;
        }

        protected static void Swap(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
