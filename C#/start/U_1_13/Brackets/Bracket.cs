using System;
using System.Collections.Generic;

namespace Brackets
{
    public class Bracket
    {
        public static bool IsStringCorrect(string str)
        {
            //var open = new List<char>();
            var open = new Stack<char>();
            foreach (char ch in str)
            {
                switch (ch)
                {
                    case '[':
                    case '(':
                        //open.Add(ch);
                        open.Push(ch);
                        break;
                    case ']':
                        //if (open.Count == 0 || open[open.Count - 1] != '[')
                        //    return false;
                        //else open.RemoveAt(open.Count - 1);
                        if (open.Count == 0 || open.Pop() != '[')
                            return false;
                        break;
                    case ')':
                        //if (open.Count == 0 || open[open.Count - 1] != '(')
                        //    return false;
                        //else open.RemoveAt(open.Count - 1);
                        if (open.Count == 0 || open.Pop() != '(')
                            return false;
                        break;
                }
            }
            return open.Count == 0;
        }

        public static bool IsStringCorrectDictionary(string str)
        {
            var pairs = new Dictionary<char, char>();
            pairs.Add('(', ')');
            pairs.Add('[', ']');
            var open = new Stack<char>();
            foreach (char ch in str)
            {
                if (pairs.ContainsKey(ch)) open.Push(ch);
                else if (pairs.ContainsValue(ch))
                {
                    if (open.Count == 0 || pairs[open.Pop()] != ch) return false;
                }
            }
            return open.Count == 0;
        }
    }
}
