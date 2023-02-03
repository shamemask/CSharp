/**
 * 4.Есть массив из целых чисел. 
 * Написать функцию, которая определяет можно ли заданное число представить суммой чисел из массива 
 * (каждое число можно использовать один раз):
 * Пример:
 * Массив: { 3, 1, 8, 5, 4}
 * Число 10 - можно представить суммой(1 + 5 + 4)
 * Число 2 - нельзя
 * **/

namespace SumFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 1, 8, 5, 4 };
            int target = 10;
            Console.WriteLine(IsSumPossible(arr, target));
        }

        static bool IsSumPossible(int[] arr, int target)
        {
            Array.Sort(arr);
            return IsSumPossible(arr, target, arr.Length - 1);
        }

        static bool IsSumPossible(int[] arr, int target, int n)
        {
            if (target == 0)
                return true;
            if (n < 0)
                return false;
            if (arr[n] > target)
                return IsSumPossible(arr, target, n - 1);
            return IsSumPossible(arr, target - arr[n], n - 1) || IsSumPossible(arr, target, n - 1);
        }
    }
}
