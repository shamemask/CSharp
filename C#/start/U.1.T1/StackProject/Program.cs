using System;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Stack<string> stackS = new Stack<string>();
            stackS.Push("Первый");
            stackS.Push("Второй");
            stackS.Push("Третий");
            Console.WriteLine(stackS.Pop());
            Console.WriteLine(stackS.Pop());
            Console.WriteLine(stackS.Pop());

            stackS.Push("Новый первый");
            stackS.Push("Новый второй");
            stackS.Push("Новый третий");
            stackS.Pop();
            foreach (var item in stackS)
                Console.WriteLine(item);
        }
    }
}
