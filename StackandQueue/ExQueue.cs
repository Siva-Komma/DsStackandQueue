using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class ExQueue
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        { 
            Node newnode= new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear= rear.Next;

            }
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = this.front;
            this.front = this.front.Next;
            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("{0} node removed from Queue", temp.data);
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.Next;
                }
            }
        }
    }
}
