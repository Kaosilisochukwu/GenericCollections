using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    class GenericQueue<T>
    {
        GenericLinkedList<T> QueueStore = new GenericLinkedList<T>();

        public bool IsEmpty() => QueueStore.isEmpty();

        public void Enqueue(T data) => QueueStore.AddTail(data);

        public void Dequeue() => QueueStore.RemoveHead();

        public int Size() => QueueStore.Size();

        public void Print() => QueueStore.Print();
    }
}
