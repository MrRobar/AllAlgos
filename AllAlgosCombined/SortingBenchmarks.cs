﻿using System;

namespace AllAlgosCombined
{

    public class SortingBenchmarks
    {

        private int[] valuesToCheck1 = new int[10_000];
        private int[] valuesToCheck2 = new int[10_000];
        private int[] _topValues = new int[10];
        private MergeSortVariant mergeSortVariant = new MergeSortVariant();

        public void Setup()
        {
            mergeSortVariant.FillArrayRandomly(valuesToCheck1);
        }

        public void MergeSort()
        {
            mergeSortVariant.MergeSort(valuesToCheck1, 0, valuesToCheck1.Length - 1);
            Array.Copy(valuesToCheck1, valuesToCheck1.Length - 10, _topValues, 0, 10);
        }

        public void StandardSort()
        {
            Array.Sort(valuesToCheck1);
        }

        public void HeapBasedSearch()
        {
            var heapVariant = new HeapVariant();
            var _heap = new MinHeap(10);
            heapVariant.FillArrayRandomly(valuesToCheck2);
            heapVariant.InitialHeapFill(_heap, valuesToCheck2);
            heapVariant.IterateThrowRemains(_heap, valuesToCheck2);
        }
    }
}