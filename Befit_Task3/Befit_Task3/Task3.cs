/**
 * 3.Есть N чиновников, каждый из которых выдает справку определенного вида. 
 * Кроме того, у каждого чиновника есть набор справок, которые нужно получить до того, 
 * как обратиться к нему за справкой. Запрограммировать алгоритм, 
 * по которому можно получить все справки. 
 * Пример:
 * N = 6.
 * Зависимость между чиновниками – {{1, [2] }, { 2, [3, 4] }, { 3, [ 5, 7] } } (т.е первый чиновник чтобы дать справку требует справку от второго, а второй от третьего и четвертого).
 * Допустимые ответы:
 * { 4,5,7,3,2,1}
 * 
 * Можно использовать алгоритм Топологической сортировки.
**/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Program
{
    static bool CheckStr(string str)
    {
        var pairs = new Dictionary<char, char>();
        pairs.Add('{', '}');
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

    static Dictionary<int, List<int>> Dict(string input)
    {
        Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
        input = input.Replace(" ", "");
        Console.WriteLine(input);
        Regex regex = new Regex(@"{(\d+),\[([\d,]+)\]}");
        MatchCollection matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            int key = int.Parse(match.Groups[1].Value);
            string[] values = match.Groups[2].Value.Split(',');
            List<int> valueList = new List<int>();
            foreach (string value in values)
            {
                valueList.Add(int.Parse(value));
            }
            result.Add(key, valueList);
        }
        return result;
    }

    static void Algorithm(int N, string str)
    {
        string numbers;
        numbers = string.Join("", str.Where(c => char.IsDigit(c)));
        List<char> chars = new List<char>();
        chars.AddRange(numbers);
        var unique = chars.GroupBy(i => i - '0').Select(i => i.Key);
        var dependencies = Dict(str);
        List<int> result = new List<int>();
        Dictionary<int, bool> visited = new Dictionary<int, bool>();
        foreach (var i in unique)
        {
            if (!visited.ContainsKey(i))
            {
                TopologicalSort(dependencies, i, visited, result);
            }
        }
        Console.WriteLine(string.Join(", ", result));
    }

    private static void TopologicalSort(Dictionary<int, List<int>> dependencies, int i, Dictionary<int, bool> visited, List<int> result)
    {
        visited[i] = true;
        if (dependencies.ContainsKey(i))
        {
            foreach (int dependency in dependencies[i])
            {
                if (!visited.ContainsKey(dependency))
                    TopologicalSort(dependencies, dependency, visited, result);
            }
        }
        result.Add(i);
    }
    static void DFS(int curr, Dictionary<int, List<int>> dependencies, bool[] visited, List<int> result)
    {
        visited[curr] = true;
        if (dependencies.ContainsKey(curr))
        {
            foreach (int next in dependencies[curr])
            {
                if (!visited[next])
                {
                    DFS(next, dependencies, visited, result);
                }
            }
        }
        result.Add(curr);
    }

    static void Main(string[] args)
    {
        string str = "";
        while (true)
        {
            Console.WriteLine("Введите режим:\n1 - тестирование\n2 - ручной ввод ");
            str = Console.ReadLine();
            if (str == "1")
            {
                Algorithm(4, "{{1, [2]}, {2,[3,4]}}"); //3,4,2,1;
                Algorithm(4, "{1,[2]}, {3,[4]}"); //2,1,4,3;
                Algorithm(6, "{{1, [2] }, {2, [3, 4] }, {3, [ 5, 7] } }"); //4,5,7,3,2,1 или 5, 7, 3, 4, 2, 1;
                Algorithm(4, "{{3, [2,4] },{5, [3] } }"); //2,4,3,5;
                Algorithm(4, "{{5, [3] }, {3, [2,4] }}"); //2,4,3,5;
                Algorithm(4, "{{ 2, [ 3, 4] }, { 1, [2] } }"); //3,4,2,1;
                Algorithm(5, "{{ 2,[ 3, 4] }, { 1,[2] }, { 3, [ 5, 4] } }"); //4,5,3,2,1 или 5, 4, 3, 2, 1;
            }
            else if (str == "2")
            {
                Console.Write("Введите количество чиновников: ");
                int N;
                while (!int.TryParse(Console.ReadLine(), out N))
                {
                    Console.Write("Введите количество чиновников: ");
                }
                Dictionary<int, List<int>> dependencies = new Dictionary<int, List<int>>
                {
                    { 1, new List<int> { 2 } },
                    { 2, new List<int> { 3, 4 } }
                };
                Console.WriteLine("Укажите зависимость между чиновниками в формате {1,[2]},{2,[3,4]} \n(т.е первый чиновник чтобы дать справку требует справку от второго, \nа второй от третьего и четвертого).");
                str = Console.ReadLine();
                while (!CheckStr(str))
                {
                    Console.WriteLine("Введите в формате {1,[2]},{2,[3,4]}: ");
                    str = Console.ReadLine();
                }
                Algorithm(N, str);
            }
        }
    }
}
