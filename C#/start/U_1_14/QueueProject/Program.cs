using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Queue<string> queueS = new Queue<string>();
            queueS.Enqueue("Первый");
            queueS.Enqueue("Второй");
            queueS.Enqueue("Третий");
            Console.WriteLine(queueS.Dequeue());
            Console.WriteLine(queueS.Dequeue());
            Console.WriteLine(queueS.Dequeue());

            queueS.Enqueue("Новый первый");
            queueS.Enqueue("Новый второй");
            queueS.Enqueue("Новый третий");
            foreach (var item in queueS)
                Console.WriteLine(item);
        }
    }
}
