using System;
using BinarySearch;
using Xunit;

namespace AlgorithmsTest
{
    public class BinarySearchTests
    {
        [Fact]
        public void BinarySearch_ValidItem()
        {
            var array = new[] {1, 6, 12, 25, 90, 155, 255, 789, 1230, 1987, 90890};
            var binarySearch = new BinarySearchAlgorithm(array);
            var validItem = 155;

            var result = binarySearch.Search(validItem);

            Assert.NotNull(result);
            Assert.Equal(5, result);
        }
        
        [Fact]
        public void BinarySearch_InvalidItem()
        {
            var array = new[] {1, 6, 12, 25, 90, 155, 255, 789, 1230, 1987, 90890};
            var binarySearch = new BinarySearchAlgorithm(array);
            var validItem = 55;

            var result = binarySearch.Search(validItem);

            Assert.Null(result);
        }
        
        [Fact]
        public void BinarySearchRecursive_ValidItem()
        {
            var array = new[] {1, 6, 12, 25, 90, 155, 255, 789, 1230, 1987, 90890};
            var binarySearch = new BinarySearchAlgorithm(array);
            var validItem = 155;

            var result = binarySearch.RecursiveSearch(validItem, 0, array.Length);

            Assert.NotNull(result);
            Assert.Equal(5, result);
        }
        
        [Fact]
        public void BinarySearchRecursive_InvalidItem()
        {
            var array = new[] {1, 6, 12, 25, 90, 155, 255, 789, 1230, 1987, 90890};
            var binarySearch = new BinarySearchAlgorithm(array);
            var invalidItem = 55;

            var result = binarySearch.RecursiveSearch(invalidItem, 0, array.Length);

            Assert.Null(result);
        }
        
        [Fact]
        public void BinarySearch_NullArray()
        {
            Assert.Throws<Exception>(()=> new BinarySearchAlgorithm(null));
        }
        
        [Fact]
        public void BinarySearch_EmptyArray()
        {
            Assert.Throws<Exception>(()=> new BinarySearchAlgorithm(new int[]{}));
        }
    }
}