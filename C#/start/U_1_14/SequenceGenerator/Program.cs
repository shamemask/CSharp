using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(4); //012301230123
            Test(3); //012012012012
            Test(2); //010101010101
            Test(1); //000000000000
        }

        static void Test(int range)
        {
            foreach (var number in GenerateCycle(range).Take(12))
            {
                Console.Write(number);
            }
            Console.WriteLine();
        }

        public static IEnumerable<int> GenerateCycle(int range)
        {
            while (true)
                for (int i = 0; i < range; i++)
                    yield return i;
        }
    }
}
