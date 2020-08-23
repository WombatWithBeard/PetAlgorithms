using System;
using System.Collections.Generic;
using System.Linq;
using SelectionSort;
using Xunit;

namespace AlgorithmsTest
{
    public class SelectionSortTests
    {
        [Fact]
        public void SelectionSort_ValidItem()
        {
            var array = new List<int> {10, 1, 4, 7, 3, 6};
            var sortedArray = new[] {1, 3, 4, 6, 7, 10};
            var sortAlgorithm = new SelectionSortAlgorithm(array);

            var result = sortAlgorithm.Sort();

            Assert.NotNull(result);
            Assert.True(sortedArray.SequenceEqual(result));
        }

        [Fact]
        public void SelectionSort_NullArray()
        {
            Assert.Throws<Exception>(() => new SelectionSortAlgorithm(null));
        }

        [Fact]
        public void SelectionSort_EmptyArray()
        {
            Assert.Throws<Exception>(() => new SelectionSortAlgorithm(new List<int>()));
        }
    }
}