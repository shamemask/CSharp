using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> lst = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(r.Next(10));
                Console.Write($"{lst[i]} ");
            }
            Console.WriteLine();
            DeleteEvenElements(lst);
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write($"{lst[i]} ");
            }
        }

        static void DeleteEvenElements(List<int> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] % 2 == 0)
                {
                    lst.RemoveAt(i);
                    i--; //нужно сместить индекс на 1 назад, т.к. теперь следующий элемент находится на том же индексе, на котором был старый (удаленный)
                }
            }
        }
    }
}
