using System;

namespace lesson_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//bool isWin = false;
			
			//int secretNumber = 5;

			Console.WriteLine("Компьютер загадал число от 1 до 10. Попробуйте его угадать.");

			Console.Write("Введите число: ");

			int userNumber = int.Parse(Console.ReadLine());
		}
	}
}
