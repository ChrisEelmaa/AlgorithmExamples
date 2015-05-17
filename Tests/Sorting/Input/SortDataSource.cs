using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using AlgorithmExamples.Sorting;
using AlgorithmExamples.Sorting.ComparisonBased;

namespace Tests.Sorting.Input
{
    public abstract class SortDataSource<T> : IEnumerable<object[]> 
        where T : IComparable<T>
    {
        protected abstract IEnumerable<T[]> GetData();

        private static IEnumerable<SortAlgorithm<T>> Implementations
        {
            get
            {
                return new SortAlgorithm<T>[]
                {
                    // Would be cool if this was dynamic,
                    // however, updating this manually is not too bad.
                    new BubbleSort<T>(),
                    new SelectionSort<T>(), 
                    new InsertionSort<T>(), 
                    new MergeSort<T>(), 
                    new QuickSort<T>(), 
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