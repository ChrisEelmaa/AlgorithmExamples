

using System.Collections.Generic;
using System.Linq;

namespace AlgorithmExamples.Misc
{
    [ProvideSourceLocation]
    public class BinarySearch : IAlgorithmImplementation
    {
        public int FindIndexOfElement(IEnumerable<int> input, int elementToFind)
        {
            var arr = input.ToArray();
            if (arr.Length == 0)
                return -1;

            int left = 0;
            int right = arr.Length - 1;

            do
            {
                int elementInMiddleIndex = left + (right - left)/2;
                int elementInMiddle = arr[elementInMiddleIndex];
                if (elementInMiddle == elementToFind)
                    return elementInMiddleIndex;

                if (elementInMiddle < elementToFind)
                {
                    left = elementInMiddleIndex + 1;
                }
                else if (elementInMiddle > elementToFind)
                {
                    right = elementInMiddleIndex - 1;
                }

            } while (left <= right);


            return -1;
        }

        #region Implementation of IAlgorithmImplementation

        public Author Author
        {
            get { return Author.ErtiChrisEelmaa; }
        }

        public DifficultyLevel Level
        {
            get { return DifficultyLevel.Easy; }
        }

        public AsymptoticWorstCaseTimeComplexity Complexity
        {
            get { return AsymptoticWorstCaseTimeComplexity.Logarithmic; }
        }

        public AlgorithmCategory Category
        {
            get { return AlgorithmCategory.Misc; }
        }

        public string Name
        {
            get { return "Binary Search"; }
        }

        public string Description
        {
            get
            {
                return
@"In computer science, a binary search or half-interval search algorithm finds the 
position of a specified input value (the search 'key') within 
an array sorted by key value.[1][2]";
            }
        }

        #endregion
    }
}
