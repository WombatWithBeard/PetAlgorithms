using System;

namespace BinarySearch
{
    public class BinarySearchAlgorithm
    {
        private readonly int[] _sortedData;

        public BinarySearchAlgorithm(int[] sortedData)
        {
            if (sortedData == null || sortedData.Length == 0)
                throw new Exception("Data is empty");

            _sortedData = sortedData;
        }

        public int? Search(int item)
        {
            var low = 0;
            var high = _sortedData.Length;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var guess = _sortedData[mid];

                if (guess == item)
                    return mid;

                if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return null;
        }

        public int? RecursiveSearch(int item, int low, int high)
        {
            var mid = low + (high - low) / 2;
            var guess = _sortedData[mid];

            if (guess == item)
                return mid;

            if (low >= high)
                return null;

            return guess > item
                ? RecursiveSearch(item, low, mid)
                : RecursiveSearch(item, mid + 1, high);
        }
    }
}