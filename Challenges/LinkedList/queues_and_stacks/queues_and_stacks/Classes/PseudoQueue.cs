using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace queues_and_stacks.Classes
{
    public class PseudoQueue
    {
        /// <summary>
        /// Pops node from top of Stack2, if stack2 is empty, it calls the method to fill from stack1
        /// </summary>
        /// <param name="stack"></param>
        /// <param name="stack2"></param>

        public void Dequeue(Stack stack, Stack stack2)
        {
            if (stack2.Top != null)
            {
                stack2.Pop();

            }

            else
            {
                while (stack.Top != null)
                    stack2.Push(stack.Pop().Value);
            }
            stack2.Pop();
        }

        public void Enqueue(Stack stack, int value)
        {
            stack.Push(value);
        }
    }

}
