using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    class GenericStack<T>
    {
        //INSTANTIATES THE GENERIClINKEDLIST CLASS AND ASSIGNS IT TO A VARIABLE STACKStore
        GenericLinkedList<T> stackStore = new GenericLinkedList<T>();

        //CREATES AN ISEMPTY METHODS AND ASSIGNS IT TO THE QueueStore ISEMPTY METHOD
        public bool isEmpty() => stackStore.isEmpty();

        //CREATES A PUSH METHODS AND ASSIGNS IT TO THE QueueStore ADDHEAD METHOD
        public void Push(T data) => stackStore.AddHead(data);

        //CREATES AN POP METHODS AND ASSIGNS IT TO THE QueueStore REMOVEHEAD METHOD
        public void Pop() => stackStore.RemoveHead();

        //CREATES A PEEK METHODS AND ASSIGNS IT TO THE QueueStore VALUE OF THE CURRENT HEAD METHOD
        public T Peek() => stackStore.Head.Data;

        //CREATES A SIZE METHODS AND ASSIGNS IT TO THE QueueStore SIZE METHOD
        public int Size() => stackStore.Size();

        //CREATES AN PRINT METHODS AND ASSIGNS IT TO THE QueueStore PRINT METHOD
        public void Print() => stackStore.Print();
    }
}
