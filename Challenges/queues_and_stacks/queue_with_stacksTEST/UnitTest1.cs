using queues_and_stacks.Classes;
using System.Collections;
using Xunit;
using StacksAndQueues.Classes;

namespace queue_with_stacksTEST
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueWorks()
        {
            //arrange
            Stack stack = new Stack();

            PseudoQueue queue = new PseudoQueue();

            //act

            queue.Enqueue(stack, 1);
            queue.Enqueue(stack, 2);
            queue.Enqueue(stack, 3);

            //assert
            Equals(stack.Top.Value);
        }

        [Fact]
        public void EnqueueWorks2()
        {
            //arrange
            Stack stack = new Stack();

            PseudoQueue queue = new PseudoQueue();

            //act

            queue.Enqueue(stack, 2);
            queue.Enqueue(stack, 3);
            queue.Enqueue(stack, 4);

            //assert
            Equals(stack.Top.Value);
        }


        [Fact]
        public void EnqueueWorks3()
        {
            //arrange
            Stack stack = new Stack();

            PseudoQueue queue = new PseudoQueue();

            //act 

            queue.Enqueue(stack, 3);
            queue.Enqueue(stack, 4);
            queue.Enqueue(stack, 5);

            //assert
            Equals(stack.Top.Value);
        }

        [Fact]
        public void DequeueWorks()
        {
            //arrange
            Stack stack = new Stack();
            Stack stack2 = new Stack();

            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(stack, 1);
            queue.Enqueue(stack, 2);
            queue.Enqueue(stack, 3);

            //act
            queue.Dequeue(stack, stack2);

            //assert
            Assert.Equal(2, stack2.Top.Value);
        }


        [Fact]
        public void DequeueWorks2()
        {
            //arrange
            Stack stack = new Stack();
            Stack stack2 = new Stack();
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(stack, 2);
            queue.Enqueue(stack, 3);
            queue.Enqueue(stack, 4);

            //act
            queue.Dequeue(stack, stack2);

            //assert
            Assert.Equal(3, stack2.Top.Value);
        }

        [Fact]
        public void DequeueWorks3()
        {
            //arrange
            Stack stack = new Stack();
            Stack stack2 = new Stack();
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(stack, 3);
            queue.Enqueue(stack, 4);
            queue.Enqueue(stack, 5);

            //act
            queue.Dequeue(stack, stack2);

            //assert
            Assert.Equal(4, stack2.Top.Value);
        }

    }
}
