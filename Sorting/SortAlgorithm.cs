using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmExamples.Sorting
{
    public abstract class SortAlgorithm<T>  :
        IAlgorithmImplementation
    {
        public abstract bool IsStableSort { get; }
        public abstract bool IsInPlace { get; }

        protected abstract IEnumerable<T> SortInternal(T[] input);

        public IEnumerable<T> Sort(
            IReadOnlyList<T> input, 
            SortDirection sortDirection)
        {
            if(input == null)
                throw new ArgumentNullException("input");

            if (input.Count <= 1)
                return input;

            var output = SortInternal(input.ToArray());
            if (sortDirection == SortDirection.Descending)
                output = output.Reverse();

            return output;
        }

        protected bool IsFirstBiggerThanSecond(T first, T second)
        {
            return AlgorithmHelper.IsFirstBiggerThanSecond(first, second);
        }

        protected bool IsSecondBiggerThanFirst(T first, T second)
        {
            return AlgorithmHelper.IsSecondBiggerThanFirst(first, second);
        }

        #region IAlgorithmImplementation

        public abstract Author Author { get; }
        public abstract DifficultyLevel Level { get; }
        public abstract AsymptoticWorstCaseTimeComplexity Complexity { get; }
        public abstract AlgorithmCategory Category { get; }
        public abstract string Name { get; }
        public abstract string Description { get; }

        #endregion
    }
}
