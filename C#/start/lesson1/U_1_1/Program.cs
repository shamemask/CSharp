using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Моя первая программа!");
            //int number = 5;
            //float fraction = 5.5f;
            //string text = "Привет!";
            //char letter = 'А';
            //Console.WriteLine(number);
            //Console.WriteLine(fraction);
            //Console.WriteLine(text);
            //Console.WriteLine(letter);
            while (true)
            {
                Console.Write("Выберите действие (+, -, *, /, 0 - выход): ");
                string op = Console.ReadLine();
                if (op == "0")
                {
                    break;
                }
                if (op != "+" && op != "-" && op != "*" && op != "/")
                {
                    continue;
                }
                Console.Write("Введите первое число: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                float num2 = float.Parse(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                if (op == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                if (op == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                if (op == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("На нуль делить нельзя!");
                    }
                    else
                    {
                        Console.WriteLine(num1 / num2);
                    }
                }
            }
        }
    }
}
