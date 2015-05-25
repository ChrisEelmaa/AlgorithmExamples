using System;
using AlgorithmExamples.Maths;
using Xunit;

namespace Tests.Maths
{
    public class FibonacciSequenceFacts
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(12, 144)]
        public void VerifyFibonacciSequenceIsCorrect(int n, int expectedFibonacciElementValue)
        {
            var fibonacciSeqImp = GetFibonacciSequenceImplementation();
            var actualFactorial = fibonacciSeqImp.Calculate(n);

            Assert.Equal(expectedFibonacciElementValue, actualFactorial);
        }

        [Fact]
        public void VerifyArgumentValidation()
        {
            var fibonacciImp = GetFibonacciSequenceImplementation();
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => fibonacciImp.Calculate(-1));

            Assert.Contains("has to be bigger", exception.Message);
        }

        private static FibonacciSequence GetFibonacciSequenceImplementation()
        {
            var factorialsImp = new FibonacciSequence();
            return factorialsImp;
        }
    }
}