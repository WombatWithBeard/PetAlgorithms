using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    public class QuickSortAlgorithm
    {
        public IEnumerable<T> QuickSort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            var quickSort = source.ToList();

            if (!quickSort.Any())
                return Enumerable.Empty<T>();

            if (quickSort.Count < 2)
                return quickSort;

            var pivot = quickSort.First();

            var smallerArray = quickSort.Skip(1).Where(x => x.CompareTo(pivot) <= 0).ToArray();

            var largerArray = quickSort.Skip(1).Where(x => x.CompareTo(pivot) > 0).ToArray();

            return QuickSort(smallerArray).Concat(new[] {pivot}).Concat(QuickSort(largerArray));
        }
    }
}