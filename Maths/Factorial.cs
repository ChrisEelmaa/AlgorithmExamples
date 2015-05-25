using System;

namespace AlgorithmExamples.Maths
{
    [ProvideSourceLocation]
    public class Factorial : IAlgorithmImplementation
    {
        public int Calculate(int n)
        {
            if(n < 0)
                throw new ArgumentOutOfRangeException("n", "n has to be bigger or equal to 0");

            if (n == 0)
                return 1;

            int result = 1;
            for (var i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
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
            get { return AsymptoticWorstCaseTimeComplexity.Factorial; }
        }

        public AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Math;}
        }

        public string Name
        {
            get { return "Factorial"; }
        }

        public string Description
        {
            get
            {
                return
@"In mathematics, the factorial of a non-negative integer n, denoted by n!, 
is the product of all positive integers less than or equal to n. ";
            }
        }

        #endregion
    }
}
