using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    //O(n Log n)
    public static class QuickSortExtension
    {
        
        public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            var quickSort = source.ToList();

            if (!quickSort.Any())
                return Enumerable.Empty<T>();

            if (quickSort.Count < 2)
                return quickSort;

            var pivot = quickSort.First();

            var smallerArray = quickSort.Skip(1).Where(item => item.CompareTo(pivot) <= 0).QuickSort();

            var largerArray = quickSort.Skip(1).Where(item => item.CompareTo(pivot) > 0).QuickSort();

            return smallerArray.Concat(new[] {pivot}).Concat(largerArray);
        }

        public static IEnumerable<T> ShortQuickSort<T>(this IEnumerable<T> source) where T : IComparable<T> =>
            !source.Any()
                ? Enumerable.Empty<T>()
                : source.Skip(1).Where(
                        item => item.CompareTo(source.First()) <= 0).ShortQuickSort()
                    .Concat(new[] {source.First()})
                    .Concat(source.Skip(1).Where(item => item.CompareTo(source.First()) > 0).ShortQuickSort());
    }
}