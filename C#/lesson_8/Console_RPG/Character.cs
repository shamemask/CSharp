using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_RPG
{
    enum TypeOfCharacter
    {
        None,
        Archer,
        Warrior,
        Wizard
    }

    enum TypeOfBonus
    {
        None,
        Life,
        Damage,
        Luck
    }

    class Character
    {
        public string name;
        public int hp = 100, damage = 30, luck = 30;
        public TypeOfCharacter type = TypeOfCharacter.None;
        public TypeOfBonus bonus = TypeOfBonus.None;

        public void Attack(Character target)
        {
            target.hp -= damage;
            Console.WriteLine($"<<<<<{name} имеет {hp} жизней и нанес {damage} урона>>>>>");
            if (target.hp <= 0) Console.WriteLine($"{target.name} был повержен!");
        }
    }
}
