using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    class GenericStack<T>
    {
        GenericLinkedList<T> stackStore = new GenericLinkedList<T>();
        public bool isEmpty() => stackStore.isEmpty();

        public void Push(T data) => stackStore.AddTail(data);

        public void Pop() => stackStore.RemoveTail();

        public T Peek() => 


    }
}
