using queues_and_stacks.Classes;
using StacksAndQueues.Classes;
using System;
using Xunit;

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


    }
}
