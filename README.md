#Introduction
This repository is used to study different **algorithms**, ranging from sorting, to manipulating strings. Some of the algorithms depend
on different data structures, which I have also implemented.

In the sense, this project can also be used to learn more about data structures,
however, that is not the main focus of this project.

**These algorithms are used only for studying. 
This is not an actual C# algorithm library.
I have written algorithms in a way which make them not suitable to use in 
projects. They can be, often times, be a little slower, as source code clarity is
the number one factor here. **

I have provided unit tests (xUnit). These make sure that algorithms are mainly correct (I hope they're 100% correct, but you can never be sure. 

**Dependencies:**

- VS2013
- xUnit VS2013 test runner
- WebEssentials (markdown files)

Hope you find this as useful, as I did when I wrote the stuff :). This is an on-going project, which will last for years. 

My goal is to keep studying/adding new algorithms. 
I'd love this repo to have **1000** algorithms eventually. 

#Overview
Current progress; **10**/1000 algorithms.

Amount of tests; TODO.

# Implementations
[Factorial](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Maths/Factorial.cs) 

In mathematics, the factorial of a non-negative integer n, denoted by n!, 
is the product of all positive integers less than or equal to n. 

------------
[FibonacciSequence sequence](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Maths/FibonacciSequence.cs) 

The FibonacciSequence sequence is a series of numbers where a number is found by 
adding up the two numbers before it. Starting with 0 and 1, 
the sequence goes 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, and so forth

------------
[Binary Search](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Misc/BinarySearch.cs) 

In computer science, a binary search or half-interval search algorithm finds the 
position of a specified input value (the search 'key') within 
an array sorted by key value.[1][2]

------------
[Maximum subarray](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Misc/MaximumSubArray.cs) 

In computer science, the maximum subarray problem is the task of finding the contiguous subarray 
within a one-dimensional array of numbers (containing at least one positive number) 
which has the largest sum. For example, for the sequence of 
values −2, 1, −3, 4, −1, 2, 1, −5, 4; the contiguous subarray with 
the largest sum is 4, −1, 2, 1, with sum 6.

------------
[BubbleSort](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Sorting/ComparisonBased/BubbleSort.cs) 

Bubble sort, sometimes referred to as sinking sort, 
is a simple sorting algorithm that repeatedly steps through the list to be sorted, 
compares each pair of adjacent items and swaps them if they are in the wrong order.

------------
[HeapSort](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Sorting/ComparisonBased/HeapSort.cs) 

Heapsort is an in-place algorithm, but it is not a stable sort. 
Heapsort was invented by J. W. J. Williams in 1964. 
This was also the birth of the heap, presented already by Williams as a useful data structure in its 
own right.

------------
[InsertionSort](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Sorting/ComparisonBased/InsertionSort.cs) 

Insertion sort is an elementary sorting algorithm that sorts one element at a time. 
Most humans, when sorting a deck of cards, will use a strategy similar to insertion sort. 
The algorithm takes an element from the list and places it in the correct location in the list.

------------
[MergeSort](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Sorting/ComparisonBased/MergeSort.cs) 

A sort algorithm that splits the items to be sorted into two groups, recursively sorts each group, 
and merges them into a final, sorted sequence. Run time is Θ(n log n).

------------
[QuickSort](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Sorting/ComparisonBased/QuickSort.cs) 

The best sorting algorithm which implements the ‘divide and conquer’ concept. 
It first divides the list into two parts by picking an element a ’pivot’. 
It then arranges the elements those are smaller than pivot into one sub list and the 
elements those are greater than pivot into one sub list by keeping the pivot in its original place.

------------
[SelectionSort](https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/Sorting/ComparisonBased/SelectionSort.cs) 

In computer science, selection sort is a sorting algorithm, specifically an in-place comparison sort. 
It has O(n2) time complexity, making it inefficient on large lists, 
and generally performs worse than the similar insertion sort.

------------

