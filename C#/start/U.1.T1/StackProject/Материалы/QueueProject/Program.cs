using System;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.push(1);
            stack.Enqueue(2);
            stack.Enqueue(3);
            Console.WriteLine(stack.Dequeue());
            Console.WriteLine(stack.Dequeue());
            Console.WriteLine(stack.Dequeue());

            Stack<string> queueS = new Stack<string>();
            queueS.Enqueue("Первый");
            queueS.Enqueue("Второй");
            queueS.Enqueue("Третий");
            Console.WriteLine(queueS.Dequeue());
            Console.WriteLine(queueS.Dequeue());
            Console.WriteLine(queueS.Dequeue());

            queueS.Enqueue("Новый первый");
            queueS.Enqueue("Новый второй");
            queueS.Enqueue("Новый третий");
            queueS.Dequeue();
            foreach (var item in queueS)
                Console.WriteLine(item);
        }
    }
}
