using System;

namespace EvenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(3); //2, 4, 6
            Test(4); //2, 4, 6, 8
            Test(5); //2, 4, 6, 8, 10
            Test(20);
        }

        static void Test(int count)
        {
            foreach (int num in GetFirstEvenNumbers(count)) 
                Console.Write($"{num} ");
            Console.WriteLine();
        }

        static int[] GetFirstEvenNumbers(int count)
        {
            int[] result = new int[count];
            for (int i = 1; i <= count; i++)
                result[i - 1] = i * 2;
            return result;
        }
    }
}
