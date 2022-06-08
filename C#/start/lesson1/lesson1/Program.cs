using System;

//Цель урока: Познакомиться со средой программирования Visual Studio,
//научиться создавать проекты, сделать консольный калькулятор.

//+ Создать новый проект в Visual Studio;
//+Ознакомиться с основными элементами интерфейса Visual Studio;
//+Разобраться в шаблонном коде программ;
//+Научиться создавать и использовать переменные;
//+Научиться читать текст из консоли (Console.ReadLine()), 
//  и преобразовывать его в числа (float.Parse());
//+Познакомиться с условиями: if, else;
//+Упростить работу с калькулятором при помощи цикла while;
//+Отполировать калькулятор с помощью операторов break и continue,
// а также логических операторов && и !=;
//-Получить домашнее задание;
//-Сделать домашнее задание.

namespace lesson1
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

			//Console.WriteLine(text);

			//Console.WriteLine(letter);
			//int i = 0;
			while (true)
			{
				Console.Write("Выберите действие (+, -, *, /, 0 - выход): ");
				

				string op = Console.ReadLine();
				if (op == "0")
				{

					Console.WriteLine("Bye");
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
				if (op == "*")
				{

					Console.WriteLine(num1 * num2);

				}
				
				//i++;

			}
		}
	}
}
