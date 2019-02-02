using System.Collections;
using StacksAndQueues.Classes;
using Stack = StacksAndQueues.Classes.Stack;

namespace queues_and_stacks.Classes
{
    public class PseudoQueue
    {

        public Stack queueStack {get; set;}
        public Stack tempStack { get; set; }

        //create new stack instances 
        public PseudoQueue()
        {
            queueStack = new Stack();
            tempStack = new Stack();
        }

        public void Enqueue(Stack StackOne, int value)
        {
            //demonstrate enqueue by pushing values into stack one
            StackOne.Push(value);
        }
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
    }

}
