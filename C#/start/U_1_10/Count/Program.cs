using System;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetElementCount(new[] { 1, 2, 2, 3, 2 }, 2)); //3
            Console.WriteLine(GetElementCount(new[] { 1, 2, 2, 3, 2 }, 3)); //1
            Console.WriteLine(GetElementCount(new[] { 9, 1, 2, 7, 9, 9, 2, 3, 2, 9, 7, 7, 1 }, 9)); //4
            Console.WriteLine(GetElementCount(new[] { 9, 1, 2, 7, 9, 9, 2, 3, 2, 9, 7, 7, 1 }, 1)); //2
            Console.WriteLine(GetElementCount(new[] { 9, 1, 2, 7, 9, 9, 2, 3, 2, 9, 7, 7, 1 }, 7)); //3
        }

        public static int GetElementCount(int[] items, int itemToCount)
        {
            int result = 0;
            //for (int i = 0; i < items.Length; i++)
            //    if (items[i] == itemToCount) result++;
            foreach (int item in items)
                if (item == itemToCount) result++;
            return result;
        }
    }
}
