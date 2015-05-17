using AlgorithmExamples;
using Xunit;

namespace Tests
{
    public class AlgorithmHelperTests
    {
        [Theory]
        [InlineData(new[] {2, 3, 4}, new[] {1, 5, 8}, new[] {1, 2, 3, 4, 5, 8})]
        [InlineData(new[] {2}, new[] {1}, new[] {1, 2})]
        [InlineData(new int[] {}, new int[] {}, new int[] {})]
        [InlineData(new int[] {}, new[] {1}, new[] {1})]
        [InlineData(new[] {2}, new int[] {}, new[] {2})]
        [InlineData(new[] {2}, new[] { 2}, new[] { 2, 2})]
        public void Merge_Should_Work(int[] first, int[] second, int[] expected)
        {
            var actual = AlgorithmHelper.Merge(first, second);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void Swap_Should_Work(int first, int second)
        {
            var firstCopy = first;
            var secondCopy = second;

            AlgorithmHelper.Swap(ref firstCopy, ref secondCopy);

            Assert.Equal(firstCopy, second);
            Assert.Equal(secondCopy, first);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        public void Max_Should_Work(int first, int second, int expected)
        {
            int actual = AlgorithmHelper.Max(first, second);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 1)]
        public void Min_Should_Work(int first, int second, int expected)
        {
            int actual = AlgorithmHelper.Min(first, second);

            Assert.Equal(expected, actual);
        }
    }
}
