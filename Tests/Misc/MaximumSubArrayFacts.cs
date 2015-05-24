using AlgorithmExamples.Misc;
using Xunit;

namespace Tests.Misc
{
    public class MaximumSubArrayFacts
    {
        [Theory]

        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { -1}, 0)]
        [InlineData(new int[] { -1, 1 }, 1)]
        [InlineData(new int[] {1, 2, 3, -7, 1}, 6)]
        [InlineData(new int[] {-7, 3, 2, -10}, 5)]
        [InlineData(new int[] { -2, 5, -1, -3, 1}, 5)]
        [InlineData(new int[] {1, 1, -1, -1, 4}, 4)]
        [InlineData(new int[] { -8, 8, -8, 8, 3, 2}, 13)]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4}, 6)]

        public void VerifyMaximumSubArrayAlgorithm(int[] input, int expectedMaximumSum)
        {
            var imp = new MaximumSubArray();

            int actualMaximumSum = imp.FindMaximumSum(input);

            Assert.Equal(expectedMaximumSum, actualMaximumSum);
        }
    }
}
