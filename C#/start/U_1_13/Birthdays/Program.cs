using System;
using System.Collections.Generic;

namespace Birthdays
{
    class Program
    {
        static Dictionary<string, string> classmates;
        
        static Program()
        {
            classmates = new Dictionary<string, string>();
            classmates.Add("Вася", "30 декабря 2010 года");
            classmates.Add("Таня", "16 мая 2009 года");
            classmates.Add("Маша", "22 сентября 2009 года");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите имя: ");
                var name = Console.ReadLine();
                if (classmates.ContainsKey(name))
                    Console.WriteLine(classmates[name]);
                else Console.WriteLine("Имя не найдено");
            }
        }
    }
}
