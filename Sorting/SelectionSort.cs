using System;
using System.Collections.Generic;

namespace AlgorithmExamples.Sorting
{
    public class SelectionSort<T> : ComparisonBasedAlgorithm<T>
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
                sortedItems++;
                Swap(ref input[best], ref input[i - 1]);

                // we have sorted every element except the first one,
                // however, if you think about it,
                // the first element is then ALSO sorted. 
                if (input.Length - 1 == sortedItems)
                    break;
            }

            return input;
        }
    }
}
