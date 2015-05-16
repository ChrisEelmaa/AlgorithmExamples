using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmExamples.Sorting;
using Xunit;

namespace Tests
{
    public class ComparisonBasedSortAlgorithmTests
    {
        public static IEnumerable<object> Implementations
        {
            get
            {
                return new[]
                {
                    // Would be cool if this was dynamic,
                    // however, updating this manually is not too bad.
                    new BubbleSort<int>()
                };
            }
        }

        public static IEnumerable<object[]> GetData()
        {
            var data = new[]
            {
                new List<int> {1, 2, 3, 4}, /* Already sorted, unique */
                new List<int> {4, 3, 2, 1}, /* Already sorted, unique */
                new List<int>{1, 1, 2, 2, 3}, /* Already sorted, duplicates */
                new List<int> {4, 4, 3, 3, 2, 1 , 1}, /* Already sorted, duplicates */ 

                new List<int>(), /* Empty, shouldn't blow up */
            };

            foreach(var inputData in data)
            {
                foreach (var implementation in Implementations)
                {
                    yield return new[]
                    {
                        implementation,
                        inputData,
                    };
                }
            }
        }

        [Theory, MemberData("GetData")]
        public void Should_Sort_Numbers_Correctly_Ascending(
            IComparisonBasedSortAlgorithm<int> sortingAlgorithm,
            IReadOnlyList<int> input)
        {
            TestSorting(sortingAlgorithm, input, SortDirection.Ascending);
        }

        [Theory, MemberData("GetData")]
        public void Should_Sort_Numbers_Correctly_Descending(
            IComparisonBasedSortAlgorithm<int> sortingAlgorithm,
            IReadOnlyList<int> input)
        {
            TestSorting(sortingAlgorithm, input, SortDirection.Descending);
        }

        private void TestSorting(
            IComparisonBasedSortAlgorithm<int> sortingAlgorithm,
            IReadOnlyList<int> input,
            SortDirection direction)
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
