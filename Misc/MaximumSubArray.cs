using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmExamples.Misc
{
    [ProvideSourceLocation]
    public class MaximumSubArray : IAlgorithmImplementation
    {
        public int FindMaximumSum(IEnumerable<int> input)
        {
            int curSum = 0;
            int bestSum = 0;

            var arr = input.ToArray();

            foreach (int t in arr)
            {
                curSum += t;
                if (curSum < 0)
                    curSum = 0;

                bestSum = Math.Max(bestSum, curSum);
            }

            return bestSum;
        }

        #region Implementation of IAlgorithmImplementation

        public Author Author
        {
            get { return Author.ErtiChrisEelmaa; }
        }

        public DifficultyLevel Level
        {
            get { return DifficultyLevel.Easy; }
        }

        public AsymptoticWorstCaseTimeComplexity Complexity
        {
            get { return AsymptoticWorstCaseTimeComplexity.Linear; }
        }

        public AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Misc; }
        }

        public string Name
        {
            get { return "Maximum subarray"; }
        }

        public string Description
        {
            get
            {
                return
@"In computer science, the maximum subarray problem is the task of finding the contiguous subarray 
within a one-dimensional array of numbers (containing at least one positive number) 
which has the largest sum. For example, for the sequence of 
values −2, 1, −3, 4, −1, 2, 1, −5, 4; the contiguous subarray with 
the largest sum is 4, −1, 2, 1, with sum 6.";
            }
        }

        #endregion
    }
}
