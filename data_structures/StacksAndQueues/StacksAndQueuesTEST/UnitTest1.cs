using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTEST
{
    public class UnitTest1
    {
        [Fact]
        public void PushNodeWorks()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            stack.Push(1);

            //Assert
            Assert.Equal(1, stack.Top.Value);

        }

        [Fact]
        public void PushWorks()
        {
            //Arrange 
            Stack stack = new Stack();

            //Act
            stack.Push(2);

            //Assert
            Assert.Equal(2, stack.Top.Value);
        }

        [Fact]
        public void PushWorks3()
        {

            //Act

            Stack stack = new Stack();


            //Arrange
            stack.Push(3);

            //Assert
            Assert.Equal(2, stack.Top.Value);
        }

        public void Popworks()
        {
            //Act

            
        }
    }
}
