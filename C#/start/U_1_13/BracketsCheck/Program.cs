using System;
using Brackets;

namespace BracketsCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bracket.IsStringCorrect("(([x])[y])"));
            Console.WriteLine(Bracket.IsStringCorrect("((])"));
            Console.WriteLine(Bracket.IsStringCorrect("(x)y)"));
            Console.WriteLine(Bracket.IsStringCorrect("((("));
            
            Console.WriteLine();

            Console.WriteLine(Bracket.IsStringCorrectDictionary("(([x])[y])"));
            Console.WriteLine(Bracket.IsStringCorrectDictionary("((])"));
            Console.WriteLine(Bracket.IsStringCorrectDictionary("(x)y)"));
            Console.WriteLine(Bracket.IsStringCorrectDictionary("((("));
        }
    }
}
