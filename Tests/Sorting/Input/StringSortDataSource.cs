using System.Collections.Generic;

namespace Tests.Sorting.Input
{
    public class StringSortDataSource : SortDataSource<string>
    {
        protected override IEnumerable<string[]> GetData()
        {
            yield return new[] {"Hello", null, "Bye"}; /* Just a case with null in it */
            yield return new[] {"Bye", null, "Hello"}; /* Reverse case of previous */
            yield return new[] {"ABCC", "DCBA", "ABC", "BBC"}; /* Arbitrary */

            yield return new string[]{}; /* Empty, shouldn't blow up */
        }
    }
}