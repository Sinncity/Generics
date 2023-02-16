using System;
using System.Collections.Generic;
namespace Queues
{
    public class Program
    {
        static void Main(string[] args)
        {

            // FIFO First in First Out

            // DEQueue = (Removing from the head for Queue)
            //ENQueue = (ADDing to the Tail for Queue) 


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Heather");
            queue.Enqueue("Terrance");
            queue.Enqueue("Amiyah");
            queue.Enqueue("Justin");

            //queue.Dequeue();
            //queue.Dequeue();

            Console.WriteLine(queue);
            Console.WriteLine(queue.Contains("Justin"));
            Console.WriteLine(queue.Peek());



        }
    }
}
