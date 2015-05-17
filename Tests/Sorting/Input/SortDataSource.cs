using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AlgorithmExamples.Sorting;

namespace Tests.Sorting.Input
{
    public abstract class SortDataSource<T> : IEnumerable<object[]> 
        where T : IComparable<T>
    {
        protected abstract IEnumerable<T[]> GetData();

        private static IEnumerable<IComparisonBasedSortAlgorithm<T>> Implementations
        {
            get
            {
                return new IComparisonBasedSortAlgorithm<T>[]
                {
                    // Would be cool if this was dynamic,
                    // however, updating this manually is not too bad.
                    new BubbleSort<T>(),
                    new SelectionSort<T>(), 
                };
            }
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            // cross join between different input types.
            return (from inputData in GetData()
                from implementation in Implementations
                select new object[]
                {
                    implementation,
                    inputData,
                }).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}