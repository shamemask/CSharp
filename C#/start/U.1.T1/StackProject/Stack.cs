using System;
using System.Collections;
using System.Collections.Generic;

namespace StackProject
{
    public class Stack<T> : IEnumerable<T>
    {
        StackItem<T> head;
        StackItem<T> tail;

        public void Push(T value)
        {
            if (head == null)
                tail = head = new StackItem<T>(value);
            else
            {
                var item = new StackItem<T>(value, tail);
                tail.Next = item;
                tail = item;
            }
        }

        public T Pop()
        {
            var result = tail.Value;
            tail = tail.Previous;
            if (tail == null)
                head = null;
            else tail.Next = null; 
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