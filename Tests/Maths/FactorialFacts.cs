using System;
using AlgorithmExamples.Maths;
using Xunit;

namespace Tests.Maths
{
    public class FactorialFacts
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(11, 39916800)]
        public void VerifyFactorialsAreCorrect(int n, int expectedFactorial)
        {
            var factorialsImp = GetFactorialImplementation();
            var actualFactorial = factorialsImp.Calculate(n);

            Assert.Equal(expectedFactorial, actualFactorial);
        }

        [Fact]
        public void VerifyArgumentValidation()
        {
            var factorialsImp = GetFactorialImplementation();
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => factorialsImp.Calculate(-1));
        
            Assert.Contains("has to be bigger", exception.Message);
        }

        private static Factorial GetFactorialImplementation()
        {
            var factorialsImp = new Factorial();
            return factorialsImp;
        }
    }
}