using AlgorithmExamples.Misc;
using Xunit;

namespace Tests.Misc
{
    public class BinarySearchFacts
    {
        [Theory]

        [InlineData(new int[] { }, 0, -1)]
        [InlineData(new int[] { -1}, -1, 0)]
        [InlineData(new int[] { -1, 1 }, -1, 0)]
        [InlineData(new int[] { -1, 1 }, 1, 1)]

        [InlineData(new int[] { 1, 2, 3 }, 4, -1)]

        [InlineData(new int[] { -1, 1, 2, 6, 8, 9 }, 6, 3)]
        [InlineData(new int[] {5, 7, 10, 100}, 100, 3)]

        [InlineData(new int[] {5, 5}, 5, 0)]
        [InlineData(new int[] {5, 7, 8, 9, 9}, 9, 3)]

        public void VerifyBinarySearchWorks(
            int[] input, 
            int elementToFind, 
            int expectedElementIndexInArray)
        {
            var imp = new BinarySearch();

            int actualElementIndexInArray = imp.FindIndexOfElement(input, elementToFind);

            Assert.Equal(expectedElementIndexInArray, actualElementIndexInArray);
        }
    }
}
