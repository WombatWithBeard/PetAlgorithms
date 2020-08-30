using System;
using System.Collections;
using System.Collections.Generic;

namespace SelectionSort
{
    //O(n^2)
    public class SelectionSortAlgorithm
    {
        private readonly List<int> _unsortedData;

        public SelectionSortAlgorithm(List<int> unsortedData)
        {
            if (unsortedData == null || unsortedData.Count == 0)
                throw new Exception("Data is empty");

            _unsortedData = unsortedData;
        }

        public int[] Sort()
        {
            var resultArr = new List<int>();
            var count = _unsortedData.Count;

            for (int i = 0; i < count; i++)
            {
                var smallest = FindSmallest();
                resultArr.Add(_unsortedData[smallest]);
                _unsortedData.RemoveAt(smallest);
            }

            return resultArr.ToArray();
        }

        private int FindSmallest()
        {
            var smallest = _unsortedData[0];
            var smallestIndex = 0;

            for (int i = 0; i < _unsortedData.Count; i++)
            {
                if (_unsortedData[i] < smallest)
                {
                    smallest = _unsortedData[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}