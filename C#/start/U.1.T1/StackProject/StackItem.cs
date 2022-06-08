using System;
using System.Collections.Generic;
using System.Text;

namespace StackProject
{
    public class StackItem<T>
    {
        public T Value { get; private set; }
        public StackItem<T> Previous { get; set; }
        public StackItem<T> Next { get; set; }
        public StackItem(T value, StackItem<T> previous = null)
        {
            Value = value;
            Previous = previous;
        }
    }
}
