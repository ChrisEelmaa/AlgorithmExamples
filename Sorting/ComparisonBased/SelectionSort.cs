using System;
using System.Collections.Generic;

namespace AlgorithmExamples.Sorting.ComparisonBased
{
    [ProvideSourceLocation]
    public class SelectionSort<T> : SortAlgorithm<T>
    {
        public override bool IsStableSort
        {
            get { return true; }
        }

        public override bool IsInPlace
        {
            get { return true; }
        }

        protected override IEnumerable<T> SortInternal(T[] input)
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
                    if (IsSecondBiggerThanFirst(input[best], input[i]))
                    {
                        best = i;
                    }
                }

                // Once the above loop is done,
                // we have found the biggest element index.
                // All we have to do now, is to swap with previous one 
                AlgorithmHelper.Swap(ref input[best], ref input[i - 1]);

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

        public override Author Author
        {
            get { return Author.ErtiChrisEelmaa; }
        }

        public override DifficultyLevel Level
        {
            get { return DifficultyLevel.VeryEasy;}
        }

        public override AsymptoticWorstCaseTimeComplexity Complexity
        {
            get {return AsymptoticWorstCaseTimeComplexity.Quadratic; }
        }

        public override AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Sorting; }
        }

        public override string Name
        {
            get { return "SelectionSort"; }
        }

        public override string Description
        {
            get { return 
@"In computer science, selection sort is a sorting algorithm, specifically an in-place comparison sort. 
It has O(n2) time complexity, making it inefficient on large lists, 
and generally performs worse than the similar insertion sort."; }
        }

        #endregion
    }
}
