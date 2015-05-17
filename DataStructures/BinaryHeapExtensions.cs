namespace AlgorithmExamples.DataStructures
{
    public static class BinaryHeapExtensions
    {
        public static bool IsValidBinaryHeap(this BinaryHeap<int> heap)
        {
            return IsHeapPropertiesFulfilled(heap, 1);
        }

        private static bool IsHeapPropertiesFulfilled(
            BinaryHeap<int> heap,
            int parentIndex)
        {
            var internalHeap = heap.GetInternalHeap();

            if (parentIndex >= internalHeap.Length)
                return true;

            int leftChildIndex = 2*parentIndex;
            int rightChildIndex = leftChildIndex + 1;

            return
                IsHeapPropertyFulfilled(heap, parentIndex, leftChildIndex) &&
                IsHeapPropertyFulfilled(heap, parentIndex, rightChildIndex) &&
                IsHeapPropertiesFulfilled(heap, leftChildIndex) &&
                IsHeapPropertiesFulfilled(heap, rightChildIndex);
        }

        private static bool IsHeapPropertyFulfilled(
            BinaryHeap<int> heap,
            int parentIndex,
            int childIndex)
        {
            var internalHeap = heap.GetInternalHeap();
            if (childIndex >= internalHeap.Length)
                return true;

            if (internalHeap[parentIndex] > internalHeap[childIndex] &&
                heap.HeapType == BinaryHeapType.MinHeap)
                return false;

            if (internalHeap[parentIndex] < internalHeap[childIndex] &&
                heap.HeapType == BinaryHeapType.MaxHeap)
                return false;

            return true;
        }
    }
}