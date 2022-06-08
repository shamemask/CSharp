using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWin = false;
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int attempts = 3;
            Console.WriteLine("Компьютер загадал число от 1 до 10. Попробуйте его угадать.");
            while (attempts > 0)
            {
                Console.WriteLine($"Количество попыток: {attempts}");
                Console.Write("Введите число: ");
                int userNumber = int.Parse(Console.ReadLine());
                if (secretNumber > userNumber)
                {
                    Console.WriteLine($"Секретное число больше числа {userNumber}");
                }
                else if (secretNumber == userNumber)
                {
                    isWin = true;                    
                }
                else
                {
                    Console.WriteLine($"Секретное число меньше числа {userNumber}");
                }
                attempts = attempts - 1;
                if (isWin == true)
                {
                    Console.WriteLine("Вы угадали");
                    break;
                }
                else if (attempts == 0)
                {
                    Console.WriteLine("Вы проиграли");
                    Console.Write($"Секретное число: {secretNumber}");
                }
            }
            Console.ReadKey();
        }
    }
}
