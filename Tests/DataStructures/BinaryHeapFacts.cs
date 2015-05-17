using System.Collections.Generic;
using System.Linq;
using AlgorithmExamples.DataStructures;
using Xunit;

namespace Tests.DataStructures
{
    public class BinaryHeapFacts
    {
        #region Data

        private static readonly List<BinaryHeapType> HeapTypes = new List<BinaryHeapType>()
        {
            BinaryHeapType.MaxHeap,
            BinaryHeapType.MinHeap
        }; 

        public static IEnumerable<object[]> GetData()
        {
            var data = new List<int[]>
            {
                new []{1},
                new []{0},
                new []{3,4, 2},
                new []{4,5,67,3,2,1,3,4,5,8,9,5,3,2,1},
                new int[]{}
            };

            return
                from d1 in data
                from d2 in HeapTypes
                select new object[] {d1, d2};
        }

        #endregion

        [Theory]
        [MemberData("GetData")]
        public void Heap_Properties_Should_Be_Respected(
            int[] elements,
            BinaryHeapType heapType)
        {
            BinaryHeap<int> heap = CreateIntHeapFrom(heapType, elements);
            Assert.True(heap.IsValidBinaryHeap());
        }

        [Fact]
        public void Heap_Basic_Functionality_Should_Work()
        {
            BinaryHeap<int> heap = CreateIntHeapFrom(BinaryHeapType.MaxHeap, 6, 4, 2, 3, 1, 9);

            var el1 = heap.ExtractTop();
            var el2 = heap.ExtractTop();
            var el3 = heap.ExtractTop();
            var el4 = heap.ExtractTop();
            var el5 = heap.ExtractTop();
            var el6 = heap.ExtractTop();

            var expectedEl1 = 9;
            var expectedEl2 = 6;
            var expectedEl3 = 4;
            var expectedEl4 = 3;
            var expectedEl5 = 2;
            var expectedEl6 = 1;

            Assert.Equal(expectedEl1, el1);
            Assert.Equal(expectedEl2, el2);
            Assert.Equal(expectedEl3, el3);
            Assert.Equal(expectedEl4, el4);
            Assert.Equal(expectedEl5, el5);
            Assert.Equal(expectedEl6, el6);

            heap.Insert(20);
            heap.Insert(10);
            heap.Insert(1337);
            heap.Insert(42);
            heap.Insert(12);

            var el7 = heap.ExtractTop();
            var expectedEl7 = 1337;

            Assert.Equal(expectedEl7, el7);
        }

        private BinaryHeap<int> CreateIntHeapFrom(BinaryHeapType heapType, params int[] input)
        {
            return new BinaryHeap<int>(heapType, input);
        }
    }
}
