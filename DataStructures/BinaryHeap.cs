using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmExamples.DataStructures
{
    public class BinaryHeap<T>
    {
        public BinaryHeapType HeapType { get; private set; }
        private readonly IList<T> _input;
        private T[] _heap;

        public BinaryHeap(BinaryHeapType heapType, IEnumerable<T> input)
        {
            HeapType = heapType;
            if(input==null)
                throw new ArgumentNullException("input");

            _input = input.ToList();
            CreateInternalHeap();
        }

        public void Insert(T value)
        {
            Array.Resize(ref _heap, _heap.Length + 1);
            _heap[_heap.Length - 1] = value;
            HeapfiyUp(_heap.Length - 1);
        }

        public bool IsEmpty()
        {
            // one element is sentil, a dummy element.
            // heap is empty.
            return _heap.Length <= 1;
        }

        public void DeleteTop()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Heap is empty.");

            AlgorithmHelper.Swap(ref _heap[_heap.Length - 1], ref _heap[1]);
            Array.Resize(ref _heap, _heap.Length - 1);

            HeapfiyDown(1);
        }

        public T ExtractTop()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Heap is empty.");

            var top = _heap[1];
            DeleteTop();
            return top;
        }

        private void CreateInternalHeap()
        {
            _heap = new T[_input.Count + 1];
            for (var i = 0; i < _input.Count; i++)
                _heap[i + 1] = _input[i];

            // In order to fix heap properties,
            // we have to locate all the non-leaf nodes,
            var fl = _heap.Length/2;
            for (var i = fl; i > 0; i--)
                HeapfiyDown(i);
        }

        internal T[] GetInternalHeap()
        {
            return _heap;
        }

        private void HeapfiyDown(int parentIndex)
        {
            if (parentIndex >= _heap.Length)
                return;

            var leftChildIndex = 2*parentIndex;
            var rightChildIndex = leftChildIndex + 1;
            var top = parentIndex;

            top = FindBestMatch(parentIndex, leftChildIndex);
            top = FindBestMatch(top, rightChildIndex);

            if (top != parentIndex)
            {
                AlgorithmHelper.Swap(ref _heap[top], ref _heap[parentIndex]);
                HeapfiyDown(top);
            }
        }

        private int FindBestMatch(int parentIndex, int childIndex)
        {
            if (childIndex < _heap.Length)
            {
                if (AlgorithmHelper.IsFirstBiggerThanSecond(
                    _heap[parentIndex],
                    _heap[childIndex]) && HeapType == BinaryHeapType.MinHeap)
                {
                    return childIndex;
                }

                if (AlgorithmHelper.IsFirstBiggerThanSecond(
                    _heap[childIndex],
                    _heap[parentIndex]) && HeapType == BinaryHeapType.MaxHeap)
                {
                    return childIndex;
                }
            }

            return parentIndex;
        }

        private void HeapfiyUp(int childIndex)
        {
            if (childIndex <= 1) 
                return;

            var parentIndex = childIndex/2;
    
            if (AlgorithmHelper.IsFirstBiggerThanSecond(_heap[parentIndex], _heap[childIndex]) &&
                HeapType == BinaryHeapType.MinHeap)
            {
                AlgorithmHelper.Swap(ref _heap[parentIndex], ref _heap[childIndex]);

            }

            if (AlgorithmHelper.IsFirstBiggerThanSecond(_heap[childIndex], _heap[parentIndex]) &&
                HeapType == BinaryHeapType.MaxHeap)
            {
                AlgorithmHelper.Swap(ref _heap[parentIndex], ref _heap[childIndex]);
            }

            HeapfiyUp(parentIndex);
        }
    }
}
