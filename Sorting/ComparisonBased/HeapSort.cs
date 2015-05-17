using System;
using System.Collections.Generic;
using AlgorithmExamples.DataStructures;

namespace AlgorithmExamples.Sorting.ComparisonBased
{
    [ProvideSourceLocation]
    public sealed class HeapSort<T> : SortAlgorithm<T>
    {
        public override bool IsStableSort
        {
            get { return false; }
        }

        public override bool IsInPlace
        {
            get { return false; }
        }

        protected override IEnumerable<T> SortInternal(T[] input)
        {
            var binaryHeap = new BinaryHeap<T>(BinaryHeapType.MinHeap, input);

            while (!binaryHeap.IsEmpty())
                yield return binaryHeap.ExtractTop();
        }

        #region IAlgorithmImplementation members

        public override Author Author
        {
            get { return Author.ErtiChrisEelmaa; }
        }

        public override DifficultyLevel Level
        {
            get { return DifficultyLevel.Easy; }
        }

        public override AsymptoticWorstCaseTimeComplexity Complexity
        {
            get { return AsymptoticWorstCaseTimeComplexity.Linearithmic; }
        }

        public override AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Sorting; }
        }

        public override string Name
        {
            get { return "HeapSort"; }
        }

        public override string Description
        {
            get
            {
                return
@"Heapsort is an in-place algorithm, but it is not a stable sort. 
Heapsort was invented by J. W. J. Williams in 1964. 
This was also the birth of the heap, presented already by Williams as a useful data structure in its 
own right.";
            }
        }
        #endregion
    }
}
