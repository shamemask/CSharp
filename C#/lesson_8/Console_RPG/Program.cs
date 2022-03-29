using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_RPG
{
    class Program
    {
        static string[] typeNames = { "Неизвестно", "Лучник", "Воин", "Маг" };
        static string[] bonusNames = { "Неизвестно", "Больше жизни", "Больше урона", "Больше удачи" };
        static List<Character> enemies = new List<Character>();

        static void Main(string[] args)
        {
            WriteTextWithBorder("Консольная РПГ");

            Character player = new Character();
            Character enemy1 = new Character();
            Character enemy2 = new Character();

            enemies.Add(enemy1);
            enemies.Add(enemy2);

            CustomizeCharacter(player, false);
            CustomizeCharacter(enemy1, true);
            CustomizeCharacter(enemy2, true);

            GameLoop(player);
        }

        static void WriteTextWithBorder(string text)
        {
            string top = "+", middle = $"| {text} |";
            for (int i = 0; i < text.Length + 2; i++)
                top += "-";
            top += "+";
            Console.WriteLine($"{top}\n{middle}\n{top}");
        }

        static void CustomizeCharacter(Character character, bool isEnemy)
        {
            ChooseName(character, isEnemy);
            ChooseType(character, isEnemy);
            ChooseBonus(character, isEnemy);
        }

        static void ChooseName(Character character, bool isEnemy)
        {
            if (isEnemy)
            {
                string[] names = { "Скелет", "Гоблин", "Кобольд", "Зомби", "Паук" };
                Random r = new Random();
                int index = r.Next(0, names.Length);
                character.name = names[index];
            }
            else
            {
                Console.Write("Введите имя: ");
                character.name = Console.ReadLine();
            }
        }

        static void ChooseType(Character character, bool isEnemy)
        {
            int choice;
            while (character.type == TypeOfCharacter.None)
            {
                if (isEnemy)
                {
                    Random r = new Random();
                    choice = r.Next(0, typeNames.Length);
                }
                else
                {
                    WriteTextWithBorder($"1 - {typeNames[(int)TypeOfCharacter.Archer]}, " +
                        $"2 - {typeNames[(int)TypeOfCharacter.Warrior]}, " +
                        $"3 - {typeNames[(int)TypeOfCharacter.Wizard]}");
                    Console.Write("Выберите тип персонажа: ");
                    choice = int.Parse(Console.ReadLine());
                }
                switch (choice)
                {
                    case 1:
                        character.type = TypeOfCharacter.Archer;
                        break;
                    case 2:
                        character.type = TypeOfCharacter.Warrior;
                        break;
                    case 3:
                        character.type = TypeOfCharacter.Wizard;
                        break;
                    default:
                        Console.WriteLine("Неверный тип");
                        break;
                }
            }
            if (!isEnemy) Console.WriteLine($"Вы выбрали: {typeNames[(int)character.type]}");
        }

        static void ChooseBonus(Character character, bool isEnemy)
        {
            int choice;
            while (character.bonus == TypeOfBonus.None)
            {
                if (isEnemy)
                {
                    Random r = new Random();
                    choice = r.Next(0, bonusNames.Length);
                }
                else
                {
                    WriteTextWithBorder($"1 - {bonusNames[(int)TypeOfBonus.Life]}, " +
                        $"2 - {bonusNames[(int)TypeOfBonus.Damage]}, " +
                        $"3 - {bonusNames[(int)TypeOfBonus.Luck]}");
                    Console.Write("Выберите бонус персонажа: ");
                    choice = int.Parse(Console.ReadLine());
                }
                switch (choice)
                {
                    case 1:
                        character.bonus = TypeOfBonus.Life;
                        character.hp = character.hp * 2;
                        break;
                    case 2:
                        character.bonus = TypeOfBonus.Damage;
                        character.damage = character.damage * 2;
                        break;
                    case 3:
                        character.bonus = TypeOfBonus.Luck;
                        character.luck = character.luck * 2;
                        break;
                    default:
                        Console.WriteLine("Неверный бонус");
                        break;
                }
            }
            if (!isEnemy) Console.WriteLine($"Вы выбрали: {bonusNames[(int)character.bonus]}");
        }

        static void GameLoop(Character player)
        {
            int numOfAction;
            Random r = new Random();
            for (int day = 1; day <= 5; day++)
            {
                for (int i = 0; i < 10; i++)
                {
                    WriteTextWithBorder("1 - идти, 2 - говорить, 3 - отдыхать, 4 - закончить день, 5 - атаковать");
                    Console.Write("Введите действие: ");
                    numOfAction = int.Parse(Console.ReadLine());
                    switch (numOfAction)
                    {
                        case 1:
                            Console.WriteLine($"{player.name} пошел куда-то.");
                            for (int j = 1; j < 6; j++)
                            {
                                int km = r.Next(1, 10);
                                Console.WriteLine($"{player.name} шел  {km} км.");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"{player.name} говорит с кем-то.");
                            for (int hour = 1; hour <= 3; hour++)
                                Console.WriteLine($"{player.name} говорил  {hour} ч.");
                            break;
                        case 3:
                            Console.WriteLine($"{player.name} отдыхает от всех {r.Next(1, 6)} ч.");
                            break;
                        case 4:
                            Console.WriteLine($"{player.name} лег спать.");
                            i = 10;
                            break;
                        case 5:
                            if (enemies.Count > 0) Battle(player, enemies[0]);
                            else Console.WriteLine("Не видать врагов в округе!");
                            break;
                        default:
                            Console.WriteLine($"{player.name} не обучен данному навыку.");
                            break;
                    }
                }
                Console.WriteLine($"{player.name} закончил день: {day}");
                Console.Write("Для продолжения нажмите Enter, а для выхода нажмите 0:: ");
                if (Console.ReadLine() == "0") break;
            }
            Console.ReadKey();
        }

        static void Battle(Character player, Character enemy)
        {
            while (enemy.hp > 0 && player.hp > 0)
            {
                player.Attack(enemy);
                if (enemy.hp > 0) enemy.Attack(player);
            }
            if (enemy.hp <= 0) enemies.Remove(enemy);
        }
    }
}
