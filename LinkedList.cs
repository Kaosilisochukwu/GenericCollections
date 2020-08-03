using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    class LinkedList<T> : ICollection<T>
    {

        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddHead(T data)
        {
            AddHead(new Node<T>(data));
        }

        public void AddHead(Node<T> node)
        {
            Node<T> temp = Head;

            Head = node;

            Head.Next = temp;

           if(Count == 0)
            {
                Tail = Head;
            }
           else
            {
                temp.Previous = Head;
            }
            Count++;
        }

        public void AddTail(T data)
        {
            AddTail(new Node<T>(data));
        }

        public void AddTail(Node<T> node)
        {
            if(Count == 0)
            {
               Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count += 1;
        }

        public Node<T> Find(T data)
        {
            Node<T> current = Head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                    return current;
                current = current.Next;
            }
            return null;
        }

        public bool isEmpty() => Count == 0;
        

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T data) => Find(data) != null;

        public int Size() => Count;

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
