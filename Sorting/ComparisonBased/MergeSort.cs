using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmExamples.Sorting.ComparisonBased
{
    [ProvideSourceLocation]
    public class MergeSort<T> : SortAlgorithm<T>
    {
        public override bool IsStableSort
        {
            get { return true; }
        }

        public override bool IsInPlace
        {
            get { return false; }
        }

        protected override IEnumerable<T> SortInternal(T[] input)
        {
            if(input.Length <= 1)
                return input;

            var middle = input.Length/2;
            var firstSegment = new ArraySegment<T>(input, 0, middle).ToArray();
            var secondSegment = new ArraySegment<T>(input, middle, input.Length - middle).ToArray();

            return AlgorithmHelper.Merge(
                SortInternal(firstSegment).ToArray(), 
                SortInternal(secondSegment).ToArray());
        }

        #region IAlgorithmImplementation

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
            get { return "MergeSort"; }
        }

        public override string Description
        {
            get
            {
                return
@"A sort algorithm that splits the items to be sorted into two groups, recursively sorts each group, 
and merges them into a final, sorted sequence. Run time is Θ(n log n).";
            }
        }

        #endregion
    }
}
