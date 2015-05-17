using System;
using System.Collections.Generic;

namespace AlgorithmExamples.Sorting.ComparisonBased
{
    [ProvideSourceLocation]
    public class InsertionSort<T> : ComparisonBasedSortAlgorithm<T>,
        IAlgorithmImplementation
        where T : IComparable<T>
    {
        protected override IEnumerable<T> SortInternal(T[] input, SortDirection sortDirection)
        {
            var sortedItems = 1;

            for (var i = sortedItems; i < input.Length; i++)
            {
                var k = i;
                while (k > 0)
                {
                    bool swapDone = false;
                    if(sortDirection == SortDirection.Descending &&
                        IsFirstBiggerThanSecond(input[k], input[k - 1]))
                    {
                        swapDone = true;
                        Swap(ref input[k], ref input[k - 1]);
                        k--;
                    }

                    if (sortDirection == SortDirection.Ascending &&
                        IsSecondBiggerThanFirst(input[k], input[k - 1]))
                    {
                        swapDone = true;
                        Swap(ref input[k], ref input[k - 1]);
                        k--;
                    }

                    if (!swapDone)
                    {
                        // we haven\t done any swaps, thus we can exit inner loop.
                        sortedItems++;
                        break;
                    }
                }

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
            get { return "InsertionSort"; }
        }

        public string Description
        {
            get
            {
                return
@"Insertion sort is an elementary sorting algorithm that sorts one element at a time. 
Most humans, when sorting a deck of cards, will use a strategy similar to insertion sort. 
The algorithm takes an element from the list and places it in the correct location in the list.";
            }
        }

        #endregion
    }
}
