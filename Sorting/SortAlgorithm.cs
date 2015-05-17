using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmExamples.Sorting
{
    public abstract class SortAlgorithm<T>  :
        IAlgorithmImplementation
        where T : IComparable<T>
    {
        public abstract bool IsStableSort { get; }
        public abstract bool IsInPlace { get; }

        protected abstract IEnumerable<T> SortInternal(T[] input, SortDirection sortDirection);

        public IEnumerable<T> Sort(
            IReadOnlyList<T> input, 
            SortDirection sortDirection)
        {
            if(input == null)
                throw new ArgumentNullException("input");

            if (input.Count <= 1)
                return input;

            return SortInternal(input.ToArray(), sortDirection);
        }

        protected bool IsFirstBiggerThanSecond(T first, T second)
        {
            // null handling.
            if (first == null && second == null) return false;
            if (first == null) return false;
            if (second == null) return true;

            var result = first.CompareTo(second);
            return result > 0;
        }

        protected bool IsSecondBiggerThanFirst(T first, T second)
        {
            if (first == null && second == null) return false;
            if (first == null) return true;
            if (second == null) return false;

            var result = first.CompareTo(second);
            return result < 0;
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
