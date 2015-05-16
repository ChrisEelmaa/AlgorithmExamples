using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmExamples.Sorting;
using Xunit;

namespace Tests.Sorting
{
    public abstract class ComparisonBasedSortAlgorithmFacts<T> where T : IComparable<T>
    {
        private static IEnumerable<object> Implementations
        {
            get
            {
                return new[]
                {
                    // Would be cool if this was dynamic,
                    // however, updating this manually is not too bad.
                    new BubbleSort<T>()
                };
            }
        }

        protected static IEnumerable<object[]> GenerateDataSet(IEnumerable<object> data)
        {
            // cross join between different input types.
            return from inputData in data 
                   from implementation in Implementations select new[]
            {
                implementation,
                inputData,
            };
        }

        protected void TestSorting<T>(
            IComparisonBasedSortAlgorithm<T> sortingAlgorithm,
            IReadOnlyList<T> input,
            SortDirection direction) where T : IComparable<T>
        {
            // assume C# implementation is correct.
            var expectedOutput = direction == SortDirection.Ascending ?
                input.OrderBy(x => x) :
                input.OrderByDescending(x => x);

            var actualOutput = sortingAlgorithm.Sort(input, direction);

            // xUnit actually recognizes that we are dealing with collections,
            // thus verifies that both sequences are equal!
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
