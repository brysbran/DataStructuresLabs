using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5StacksandQueues
{

    public class IntegerQueue
    {
        private static Queue<int> queue = new Queue<int>();
        private static Stack<int> stack1 = new Stack<int>();
        private static Stack<int> stack2 = new Stack<int>();

        public static void Enqueue(int temp)
        {
            //pops items in stack 1 into stack2
            while (stack1.Count > 0)
            {
               stack2.Push(stack1.Pop());
            }

            stack1.Push(temp);

            //pops stack 1 into stack2
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop()); 
            }
            

        }

        public static void Dequeue()
        {
            if(stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("There is nothing in the queue.");
            }
            else
            {
                Console.WriteLine(stack1.Pop());
                
            }
            
        }

    }
}
