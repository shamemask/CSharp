using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueProject
{
    public class Queue<T> : IEnumerable<T>
    {
        QueueItem<T> head;
        QueueItem<T> tail;

        public void Enqueue(T value)
        {
            if (head == null)
                tail = head = new QueueItem<T>(value);
            else
            {
                var item = new QueueItem<T>(value);
                tail.Next = item;
                tail = item;
            }
        }

        public T Dequeue()
        {
            var result = head.Value;
            head = head.Next;
            if (head == null)
                tail = null;
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    //public class Queue
    //{
    //    QueueItem head;
    //    QueueItem tail;

    //    public void Enqueue(int value)
    //    {
    //        if (head == null)
    //            tail = head = new QueueItem(value);
    //        else
    //        {
    //            var item = new QueueItem(value);
    //            tail.Next = item;
    //            tail = item;
    //        }
    //    }

    //    public int Dequeue()
    //    {
    //        var result = head.Value;
    //        head = head.Next;
    //        if (head == null)
    //            tail = null;
    //        return result;
    //    }
    //}
}