using System;
using System.Collections;
using System.Collections.Generic;

namespace StackProject
{
    public class Stack<T> : IEnumerable<T>
    {
        StackItem<T> head;
        StackItem<T> tail;

        public void push(T value)
        {
            if (head == null)
                tail = head = new StackItem<T>(value);
            else
            {
                var item = new StackItem<T>(value);
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
}