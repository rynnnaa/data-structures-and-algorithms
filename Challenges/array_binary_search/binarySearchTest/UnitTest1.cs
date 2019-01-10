using System;
using Xunit;
using array_binary_search;

namespace binarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void notInArray()
        {
            int[] binaryArray = { 1, 2, 3, 4, 5, 6 };
            int searchKey = 7;
            Assert.Equal(-1, Program.BinarySearch(binaryArray, searchKey));
        }
    }
}