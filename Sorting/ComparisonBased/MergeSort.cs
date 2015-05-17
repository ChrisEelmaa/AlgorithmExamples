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

            return Merge(
                SortInternal(firstSegment).ToArray(), 
                SortInternal(secondSegment).ToArray());
        }


        private T[] Merge(T[] first, T[] second)
        {
            var output = new T[first.Length + second.Length];
            var defaultEqualityComparer = EqualityComparer<T>.Default;
            
            int firstPointer = 0;
            int secondPointer = 0;
            int outputPointer = 0;

            while (true)
            {
                var isFirstPointerValid = firstPointer < first.Length;
                var isSecondPointerValid = secondPointer < second.Length;
                if (!isFirstPointerValid && !isSecondPointerValid)
                    break;

                if (isFirstPointerValid && isSecondPointerValid)
                {
                    if (defaultEqualityComparer.Equals(first[firstPointer], second[secondPointer]))
                    {
                        output[outputPointer++] = first[firstPointer++];
                        output[outputPointer++] = second[secondPointer++];
                        continue;
                    }

                    var max = AlgorithmHelper.Min(first[firstPointer], second[secondPointer]);
                    output[outputPointer++] = defaultEqualityComparer.Equals(first[firstPointer], max)
                        ? first[firstPointer++]
                        : second[secondPointer++];
                }
                else
                {
                    var currentPointer = isFirstPointerValid ? firstPointer : secondPointer;
                    var array = isFirstPointerValid ? first : second;

                    for (; currentPointer < array.Length; currentPointer++)
                    {
                        output[outputPointer++] = array[currentPointer];
                    }

                    break;
                }
            }

            return output;
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
