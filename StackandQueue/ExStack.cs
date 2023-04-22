using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class ExStack
    {
        Node top;
        public ExStack()
        {
            top = null;
        }
        public void push(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = top;
            top = newnode;
        }
        public void Display()
        {
            if(top==null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp= top;
                while(temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.Next;
                }
            }
        }
    }
}
