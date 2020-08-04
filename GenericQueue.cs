using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    class GenericQueue<T>
    {
        //INSTANTIATES THE GENERIClINKEDLIST CLASS AND ASSIGNS IT TO A VARIABLE QueueStore
        GenericLinkedList<T> QueueStore = new GenericLinkedList<T>();

        //CREATES AN ISEMPTY METHODS AND ASSIGNS IT TO THE QueueStore ISEMPTY METHOD
        public bool IsEmpty() => QueueStore.isEmpty();

        //CREATE AN ENQUEUE METHOD AND ASSINGS QueueStore ADDTAIL METHOD TO IT
        public void Enqueue(T data) => QueueStore.AddTail(data);

        //CREATE AN DEQUEUE METHOD AND ASSINGS QueueStore REMOVEHEAD METHOD TO IT
        public void Dequeue() => QueueStore.RemoveHead();

        //CREATE A SIZE METHOD AND ASSINGS QueueStore SIZE METHOD TO IT
        public int Size() => QueueStore.Size();

        //CREATE A PRINT METHOD AND ASSINGS QueueStore PRINT METHOD TO IT
        public void Print() => QueueStore.Print();
    }
}
