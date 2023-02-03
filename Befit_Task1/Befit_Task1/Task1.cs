/**
 * 1.Напишите простой класс асинхронной обработки задач. Класс должен иметь метод для добавления задач, принимающий объекты типа Task:
 * public delegate void Task();
 * Задачи должны выполняться последовательно. Также должна быть возможность дождаться окончания выполнения всех заданий.
**/

using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

public delegate void Task();

public class AsyncTaskProcessor
{
    private readonly ConcurrentQueue<Task> _tasks = new ConcurrentQueue<Task>();

    public void AddTask(Task task)
    {
        _tasks.Enqueue(task);
    }

    public async void ProcessTasksAsync()
    {
        while (_tasks.TryDequeue(out Task task))
        {
            task();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Тест
        AsyncTaskProcessor processor = new AsyncTaskProcessor();

        // Добавление задач в очередь
        processor.AddTask(() => Console.WriteLine("Task 1"));
        processor.AddTask(() => Console.WriteLine("Task 2"));
        processor.AddTask(() => Console.WriteLine("Task 3"));

        // Выполнение задач
        processor.ProcessTasksAsync();

        Console.WriteLine("All tasks are completed");
    }
}