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
            Assert.Equal(8, stack.Top.Value);

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

        [Fact]
        public void PeekWorks2()
        {
            //Arrange
            Stack stack = new Stack();
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            //Act
            Node peeks = stack.Peek();

            //Assert
            Assert.Equal(6, peeks.Value);

        }

        [Fact]
        public void PeekWorks3()
        {
            //Arrange
            Stack stack = new Stack();
            stack.Push(3);

            //Act
            Node peeks = stack.Peek();

            //Assert
            Assert.Equal(3, peeks.Value);

        }

        [Fact]
        public void EnqueueWorks()
        {
            //Arrange
            Node node = new Node(1);
            Queue queue = new Queue(node);

            //Act
            queue.Enqueue(2);

            //Assert
            Assert.Equal(2, queue.Rear.Value);
        }

        [Fact]
        public void EnqueueWorks2()
        {
            //Arrange
            Node node = new Node(1);
            Queue queue = new Queue(node);

            //Act
            queue.Enqueue(3);

            //Assert
            Assert.Equal(3, queue.Rear.Value);
        }

        [Fact]
        public void EnqueueWorks3()
        {
            //Arrange
            Node node = new Node(1);
            Queue queue = new Queue(node);

            //Act
            queue.Enqueue(9);


            //Assert
            Assert.Equal(9, queue.Rear.Value);
       
        }

        [Fact]
        public void DequeueWorks()
        {

            //Arrange
            Node node = new Node(1);
            Queue queue = new Queue(node);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(3);


            //Act
            queue.Dequeue();

            //Assert.
            Assert.Equal(3, queue.Front.Value);
        }

        [Fact]
        public void DequeueWorks2()
        {
            //Arrange
            Node node = new Node(1);
            Queue queue = new Queue(node);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            //Act
            queue.Dequeue();

       
            //Assert
            Assert.Equal(4, queue.Front.Value);
        }
        [Fact]
        public void DequeueWorks3()
        {
            //Arrange
            Node node = new Node(1);
            Queue queue = new Queue(node);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);

            //Act
            queue.Dequeue();

            //Assert
            Assert.Equal(6, queue.Front.Value);
        
        }

        [Fact]
        public void QueuePeekWorks()
        {
            Node node = new Node(2);
            Queue queue = new Queue(node);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            //Act
            Node peeks = queue.Peek();

            //Assert
            Assert.Equal(2, peeks.Value);
        }

        [Fact]
        public void QueuePeekWorks2()
        {
            Node node = new Node(4);
            Queue queue = new Queue(node);
        }
    }

  
}
