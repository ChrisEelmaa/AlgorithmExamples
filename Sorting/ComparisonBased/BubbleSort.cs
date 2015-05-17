using System;
using System.Collections.Generic;

namespace AlgorithmExamples.Sorting.ComparisonBased
{
    [ProvideSourceLocation]
    public sealed class BubbleSort<T> : 
        ComparisonBasedSortAlgorithm<T>,
        IAlgorithmImplementation
        where T : IComparable<T>
    {
        protected override IEnumerable<T> SortInternal(T[] input, SortDirection sortDirection)
        {
            bool __EVER__ = true;

            int indexOfElementBeforeLast = input.Length - 1;
            int sortedElements = 0;

            for(;__EVER__;)
            {
                bool swapDone = false;

                // we start from zero, and keep swapping the biggest/smallest element,
                // with the next element, until it finds it's place.
                for (var k = 0; k < indexOfElementBeforeLast - sortedElements; k++)
                {
                    if (IsFirstBiggerThanSecond(input[k], input[k + 1]) &&
                        sortDirection == SortDirection.Ascending)
                    {
                        Swap(ref input[k], ref input[k + 1]);
                        swapDone = true;
                    }

                    if (IsSecondBiggerThanFirst(input[k], input[k + 1]) &&
                        sortDirection == SortDirection.Descending)
                    {
                        Swap(ref input[k], ref input[k + 1]);
                        swapDone = true;
                    }
                }

                // If our bubble sort algorithm hasn't done any
                // swaps, then the array is already sorted, in which case
                // we can just quit happily.
                if (!swapDone) 
                    break;

                // Otherwise, if we have done any swaps,
                // it means one element is now in its right position,
                // which means we don't have to touch it again in the next cycle.

                // note that these options still leave the worst running time as O(n^2)
                sortedElements++;
            }

            return input;
        }

        #region IAlgorithmImplementation members

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
            get { return AsymptoticWorstCaseTimeComplexity.Quadratic; }
        }

        public AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Sorting; }
        }

        public string Name
        {
            get { return "BubbleSort"; }
        }

        public string Description
        {
            get
            {
                return
@"Bubble sort, sometimes referred to as sinking sort, 
is a simple sorting algorithm that repeatedly steps through the list to be sorted, 
compares each pair of adjacent items and swaps them if they are in the wrong order.";
            }
        }
        #endregion
    }
}
