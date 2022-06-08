using System;

namespace PrettyTextLib
{
    public class PrettyText
    {
        public static void WriteTextWithBorder(string text)
        {
            string top = "+", middle = $"| {text} |";
            for (int i = 0; i < text.Length + 2; i++)
                top += "-";
            top += "+";
            Console.WriteLine($"{top}\n{middle}\n{top}");
        }
    }
}
