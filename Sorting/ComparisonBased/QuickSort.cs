using System.Collections.Generic;

namespace AlgorithmExamples.Sorting.ComparisonBased
{
    [ProvideSourceLocation]
    public class QuickSort<T> : SortAlgorithm<T>
    {
        public override bool IsStableSort
        {
            get { return false; }
        }

        public override bool IsInPlace
        {
            get { return true; }
        }

        protected override IEnumerable<T> SortInternal(T[] input)
        {
            SortInternal(input, 0, input.Length - 1);
            return input;
        }

        private void SortInternal(T[] input, int low, int high)
        {
            var elementsInRage = high - low;
            if (elementsInRage < 1)
                return; // already sorted, single element.

            int middle = Partition(input, 
                low, 
                high);

            SortInternal(input, low, middle - 1);
            SortInternal(input, middle + 1, high);
        }

        private int Partition(T[] input, 
            int low, 
            int high)
        {
            // preferred way of finding the middle,
            // as this won't overflow.
            var middleElementIndex = low + (high - low) / 2;

            int newPosition = low;

            // calculate the "rank" of middle element
            // by rank I mean, what is the correct sorted position of an element?
            for (var i = low; i <= high; i++)
            {
                if (i != middleElementIndex &&
                    IsFirstBiggerThanSecond(input[middleElementIndex], input[i]))
                {
                    newPosition++;
                }
            }

            if (middleElementIndex != newPosition)
            {
                AlgorithmHelper.Swap(
                    ref input[middleElementIndex], 
                    ref input[newPosition]);
                middleElementIndex = newPosition;
            }

            int leftSideIndex = low;
            int rightSideIndex = middleElementIndex + 1;

            while (leftSideIndex < middleElementIndex &&
                rightSideIndex <= high)
            {
                var isLeftSideElementInCorrectPlace = IsFirstBiggerThanSecond(
                    input[middleElementIndex],
                    input[leftSideIndex]);

                var isRightSideElementInCorrectPlace = IsFirstBiggerThanSecond(
                    input[rightSideIndex],
                    input[middleElementIndex]);

                if (isLeftSideElementInCorrectPlace && isRightSideElementInCorrectPlace)
                {
                    leftSideIndex++;
                    rightSideIndex++;
                    continue;
                }

                if (!isLeftSideElementInCorrectPlace && !isRightSideElementInCorrectPlace)
                {
                    AlgorithmHelper.Swap(ref input[leftSideIndex], ref input[rightSideIndex]);
                    leftSideIndex++;
                    rightSideIndex++;
                    continue;
                }

                if (isLeftSideElementInCorrectPlace) leftSideIndex++;
                if (isRightSideElementInCorrectPlace) rightSideIndex++;
            }

            return middleElementIndex;
        }


        #region IAlgorithmImplementation members

        public override Author Author
        {
            get { return Author.ErtiChrisEelmaa; }
        }

        public override DifficultyLevel Level
        {
            get { return DifficultyLevel.Medium; }
        }

        public override AsymptoticWorstCaseTimeComplexity Complexity
        {
            get { return AsymptoticWorstCaseTimeComplexity.Quadratic; }
        }

        public override AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Sorting; }
        }

        public override string Name
        {
            get { return "QuickSort"; }
        }

        public override string Description
        {
            get
            {
                return
@"The best sorting algorithm which implements the ‘divide and conquer’ concept. 
It first divides the list into two parts by picking an element a ’pivot’. 
It then arranges the elements those are smaller than pivot into one sub list and the 
elements those are greater than pivot into one sub list by keeping the pivot in its original place.";
            }
        }

        #endregion
    }
}
