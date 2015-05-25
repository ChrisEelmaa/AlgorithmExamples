using System;
using System.Diagnostics;

namespace AlgorithmExamples.Maths
{
    [ProvideSourceLocation]
    public class FibonacciSequence : IAlgorithmImplementation
    {
        public int Calculate(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException("n", "n has to be bigger or equal to 0");

            if (n <= 1)
                return n;

            // set the initial state
            int fMinusOne = 1;
            int fMinusTwo = 0;

            int fElementh = 2;

            for (; fElementh <= n; fElementh++)
            {
                int sum = fMinusOne + fMinusTwo;

                fMinusTwo = fMinusOne;
                fMinusOne = sum;
            }

            return fMinusOne;
        }

        #region Implementation of IAlgorithmImplementation

        public Author Author
        {
            get { return Author.ErtiChrisEelmaa; }
        }

        public DifficultyLevel Level
        {
            get { return DifficultyLevel.VeryEasy; }
        }

        public AsymptoticWorstCaseTimeComplexity Complexity
        {
            get { return AsymptoticWorstCaseTimeComplexity.Linear; }
        }

        public AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Math; }
        }

        public string Name
        {
            get { return "FibonacciSequence sequence"; }
        }

        public string Description
        {
            get
            {
                return
@"The FibonacciSequence sequence is a series of numbers where a number is found by 
adding up the two numbers before it. Starting with 0 and 1, 
the sequence goes 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, and so forth";
            }
        }

        #endregion
    }
}
