using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue");
            ExStack ex = new ExStack();
            ex.push(56);
            ex.push(30);
            ex.push(70);
            ex.Pop();
            ex.Peek();
            ex.Display();
            ExQueue eq = new ExQueue();
            eq.Enqueue(56);
            eq.Enqueue(30);
            eq.Enqueue(70);
            eq.Dequeue();
            eq.Display();
            Console.ReadLine();
        }
    }
}
