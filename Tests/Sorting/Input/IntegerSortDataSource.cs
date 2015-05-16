using System.Collections.Generic;

namespace Tests.Sorting.Input
{
    public class IntegerSortDataSource : SortDataSource<int>
    {
        protected override IEnumerable<int[]> GetData()
        {
            yield return new []{1, 2, 3, 4}; /* Already sorted, unique */
            yield return new []{4, 3, 2, 1}; /* Already sorted, unique */
            yield return new []{1, 1, 2, 2, 3}; /* Already sorted, duplicates */
            yield return new []{4, 4, 3, 3, 2, 1, 1}; /* Already sorted, duplicates */

            yield return new int[]{}; /* Empty, shouldn't blow up */
        }
    }
}