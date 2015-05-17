using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AlgorithmExamples.Sorting.ComparisonBased
{
    [ProvideSourceLocation]
    public class SelectionSort<T> : ComparisonBasedSortAlgorithm<T>,
        IAlgorithmImplementation
        where T : IComparable<T>
    {
        protected override IEnumerable<T> SortInternal(T[] input, SortDirection sortDirection)
        {
            // Selection sort might be the easiest sort algorithm.
            // Atleast, to understand.
            // Namely, we scan array once, pick the biggest element, add it to sorted side,
            // and keep repeating with unsorted items.

            var sortedItems = 0;

            while (true)
            {
                var best = 0; // assume element 0 is currently the best one.
                int i;
                for (i = 1; i < input.Length - sortedItems; i++)
                {
                    if (IsFirstBiggerThanSecond(input[best], input[i]) &&
                        sortDirection == SortDirection.Descending)
                    {
                        best = i;
                    }

                    if (IsSecondBiggerThanFirst(input[best], input[i]) &&
                        sortDirection == SortDirection.Ascending)
                    {
                        best = i;
                    }
                }

                // Once the above loop is done,
                // we have found the biggest element index.
                // All we have to do now, is to swap with previous one 
                Swap(ref input[best], ref input[i - 1]);

                // we have sorted every element except the first one,
                // however, if you think about it,
                // the first element is then ALSO sorted
                sortedItems++; 
                if (input.Length - 1 == sortedItems)
                    break;
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
            get { return DifficultyLevel.VeryEasy;}
        }

        public AsymptoticWorstCaseTimeComplexity Complexity
        {
            get {return AsymptoticWorstCaseTimeComplexity.Quadratic; }
        }

        public AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Sorting; }
        }

        public string Name
        {
            get { return "SelectionSort"; }
        }

        public string Description
        {
            get { return 
@"In computer science, selection sort is a sorting algorithm, specifically an in-place comparison sort. 
It has O(n2) time complexity, making it inefficient on large lists, 
and generally performs worse than the similar insertion sort."; }
        }

        #endregion
    }
}
