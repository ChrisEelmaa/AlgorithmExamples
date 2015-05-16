using System.Collections.Generic;
using AlgorithmExamples.Sorting;
using Xunit;

namespace Tests.Sorting
{
    public class IntegerBasedSortAlgorithmFacts : ComparisonBasedSortAlgorithmFacts<int>
    {
        public static IEnumerable<object[]> GetData()
        {
            return GenerateDataSet(new object[]
            {
                new List<int> {1, 2, 3, 4}, /* Already sorted, unique */
                new List<int> {4, 3, 2, 1}, /* Already sorted, unique */
                new List<int> {1, 1, 2, 2, 3}, /* Already sorted, duplicates */
                new List<int> {4, 4, 3, 3, 2, 1, 1}, /* Already sorted, duplicates */

                new List<int>(), /* Empty, shouldn't blow up */
            });
        }

        [Theory, MemberData("GetData")]
        public void Should_Sort_Numbers_Correctly_Ascending<T>(
            IComparisonBasedSortAlgorithm<int> sortingAlgorithm,
            IReadOnlyList<int> input) 
        {
            TestSorting(sortingAlgorithm, input, SortDirection.Ascending);
        }

        [Theory, MemberData("GetData")]
        public void Should_Sort_Numbers_Correctly_Descending<T>(
            IComparisonBasedSortAlgorithm<int> sortingAlgorithm,
            IReadOnlyList<int> input)
        {
            TestSorting(sortingAlgorithm, input, SortDirection.Descending);
        }
    }
}