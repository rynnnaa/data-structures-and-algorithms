using System;
using Xunit;
using k_thValue;
using LinkedList;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PlaceFromEndWorksAga()
        {
            //Arrange
            int value = 1;

            //Act
            int result = k_thValue.Program.ValueByEnd(value);

            //Assert
            Assert.Equal(2, result);
        }
    }
}
