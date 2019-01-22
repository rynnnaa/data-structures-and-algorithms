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
            Assert.Equal(3, stack.Top.Value);
        }

        [Fact]
        public void Popworks()
        {

            //Arrange
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push(4);

            //Act
            stack.Pop();

            //Assert
            Assert.Equal(2, stack.Top.Value);
        }
       
        [Fact]
        public void PopWorks2()
        {

            //Arrange
            Stack stack = new Stack();
            stack.Push(8);
            stack.Push(9);

            //Act
            stack.Pop();

            //Assert
            Assert.Equal (8, stack.Top.Value);

        }

        [Fact]
        public void PopWorks3()
        {
            //Arrange
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(6);

            //Act
            stack.Pop();

            //Assert
            Assert.Equal(5, stack.Top.Value);

        }
       
        [Fact]
        public void PeekWorks()
        {
            //Arrange
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //Act
            Node peeks = stack.Peek();

            //Assert
            Assert.Equal(3, peeks.Value);

        }
    }
}
