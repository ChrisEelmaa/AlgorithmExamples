using System.Collections.Generic;
using AlgorithmExamples.Sorting;
using Xunit;

namespace Tests.Sorting
{
    public class StringBasedSortAlgorithmFacts : ComparisonBasedSortAlgorithmFacts<string>
    {
        public static IEnumerable<object[]> GetData()
        {
            return GenerateDataSet(new object[]
            {
                new List<string> {"Hello", null, "Bye"}, /* Just a case with null in it */
                new List<string> {"Bye", null, "Hello"}, /* Reverse case of previous */
                new List<string> {"ABCC", "DCBA", "ABC", "BBC"}, /* Arbitrary */

                new List<string>(), /* Empty, shouldn't blow up */
            });
        }

        [Theory, MemberData("GetData")]
        public void Should_Sort_Strings_Correctly_Ascending(
            IComparisonBasedSortAlgorithm<string> sortingAlgorithm,
            IReadOnlyList<string> input)
        {
            TestSorting(sortingAlgorithm, input, SortDirection.Ascending);
        }

        [Theory, MemberData("GetData")]
        public void Should_Sort_Strings_Correctly_Descending(
            IComparisonBasedSortAlgorithm<string> sortingAlgorithm,
            IReadOnlyList<string> input)
        {
            TestSorting(sortingAlgorithm, input, SortDirection.Descending);
        }
    }
}