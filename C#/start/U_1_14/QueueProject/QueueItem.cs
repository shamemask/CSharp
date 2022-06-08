using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class QueueItem<T>
    {
        public T Value { get; private set; }
        public QueueItem<T> Next { get; set; }
        public QueueItem(T value, QueueItem<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
    //public class QueueItem
    //{
    //    public int Value { get; private set; }
    //    public QueueItem Next { get; set; }
    //    public QueueItem(int value, QueueItem next = null)
    //    {
    //        Value = value;
    //        Next = next;
    //    }
    //}
}
