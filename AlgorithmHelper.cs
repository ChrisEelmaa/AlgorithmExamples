using System.Collections.Generic;

namespace AlgorithmExamples
{
    public static class AlgorithmHelper
    {
        public static T[] Merge<T>(T[] first, T[] second, 
            EqualityComparer<T> comparer = null)
        {
            comparer = comparer ?? EqualityComparer<T>.Default;

            var output = new T[first.Length + second.Length];
            
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
                    if (comparer.Equals(first[firstPointer], second[secondPointer]))
                    {
                        output[outputPointer++] = first[firstPointer++];
                        output[outputPointer++] = second[secondPointer++];
                        continue;
                    }

                    var max = Min(first[firstPointer], second[secondPointer]);
                    output[outputPointer++] = comparer.Equals(first[firstPointer], max)
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

        public static void Swap<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        public static T Max<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) > 0) ? x : y;
        }

        public static T Min<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) < 0) ? x : y;
        }
    }
}
