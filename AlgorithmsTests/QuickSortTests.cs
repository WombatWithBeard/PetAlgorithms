using System.Collections.Generic;
using System.Linq;
using QuickSort;
using Xunit;

namespace AlgorithmsTest
{
    public class QuickSortTests
    {
        [Fact]
        public void QuickSort_ValidItem()
        {
            var array = new List<int> {10, 1, 4, 7, 3, 6, 12, 15};
            var sortedArray = new[] {1, 3, 4, 6, 7, 10, 12, 15};
            var sortAlgorithm = new QuickSortAlgorithm();

            var result = sortAlgorithm.QuickSort(array);

            Assert.NotNull(result);
            Assert.True(sortedArray.SequenceEqual(result));
        }
        
        [Fact]
        public void QuickSortExtension_ValidItem()
        {
            var array = new List<int> {10, 1, 4, 7, 3, 6, 12, 15};
            var sortedArray = new[] {1, 3, 4, 6, 7, 10, 12, 15};

            var result = array.QuickSort();

            Assert.NotNull(result);
            Assert.True(sortedArray.SequenceEqual(result));
        }
        
        [Fact]
        public void ShortQuickSortExtension_ValidItem()
        {
            var array = new List<int> {10, 1, 4, 7, 3, 6, 12, 15};
            var sortedArray = new[] {1, 3, 4, 6, 7, 10, 12, 15};

            var result = array.ShortQuickSort();

            Assert.NotNull(result);
            Assert.True(sortedArray.SequenceEqual(result));
        }
    }
}