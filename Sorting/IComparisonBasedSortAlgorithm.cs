using System;
using System.Collections.Generic;

namespace AlgorithmExamples.Sorting
{
    /// <summary>
    /// This interface is for sorting algorithms that work by 
    /// comparing different elements.
    /// 
    /// These can include; merge sort, bubble sort, quicksort, and so on.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IComparisonBasedSortAlgorithm<T> where T : IComparable<T>
    {
        IEnumerable<T> Sort(IReadOnlyList<T> input, SortDirection sortDirection);
    }
}