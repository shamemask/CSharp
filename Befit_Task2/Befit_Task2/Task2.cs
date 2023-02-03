/**
 * 2.Напишите реализацию метода, возвращающего частичные суммы ряда
 * IEnumerable<double> GetRowSums(IEnumerable<double> row);
 * Например, для ряда
 * 1, 2, 3, 4, ...
 * он должен вернуть
 * 1, 3, 6, 10, ...
 * Возможность переполнения типа double при суммировании можно не учитывать. (Рекомендация: используйте LINQ).
**/



public static class RowSum
{
    public static IEnumerable<double> GetRowSums(IEnumerable<double> row)
    {
        double sum = 0;
        return row.Select(x => sum += x);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Тест 1, 2, 3, 4, ...
        var sequence = Enumerable.Range(1, 10).Select(x => (double)x);
        var rowSums = RowSum.GetRowSums(sequence);
        Console.WriteLine(string.Join(", ", rowSums));
    }
}
