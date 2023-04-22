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
            ex.push(20);
            ex.push(40);
            ex.push(30);
            ex.Display();
            ExQueue eq = new ExQueue();
            eq.Enqueue(20);
            eq.Enqueue(30);
            eq.Enqueue(40);
            eq.Dequeue();
            ex.Display();
            Console.ReadLine();
        }
    }
}
