using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    class GenericLinkedList<T>
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
        
        public T Search(T data)
        {
            return Find(data).Data;
        }

        public int Add(T data)
        {
            AddHead(data);
            return Count;
        }
        public bool Contains(T data) => Find(data) != null;

        public int Size() => Count;



        public void Insert(T data, int index)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = Head;
            if (index >= Count)
                throw new ArgumentException($"index is out of range.");
            int currentIndex = 0;
            while(tempNode != null)
            {
                if(currentIndex == index)
                {
                    break;
                }
                currentIndex++;
                tempNode = tempNode.Next;
            }
            if(tempNode == Tail)
            {
                AddTail(data);
            }
            else
            {

            }
            Node<T> next = tempNode.Next;
            Node<T> previous = tempNode.Previous;
            if(previous == null)
            {
                Head = node;
                Head.Next = tempNode;
                previous = Head;
            }
            //else if(next == null)
            //{
            //    Tail = node;
            //    tempNode.Next = Tail;
            //    Tail.Previous = tempNode;
            //}
            else
            {
                previous.Next = node;
                node.Next = tempNode;
                tempNode.Previous = node;
                node.Previous = previous;
            }
            Count++;
        }
        
        public void RemoveTail()
        {
            if(Count != 0)
            {
                Tail = Tail.Previous;
                Count--;
                if(Count == 0)
                {
                    Head = null;
                }
                else
                {
                    Tail.Next = null;
                }
            }
        }

        public void RemoveHead()
        {
            if(Count != 0)
            {
                Head = Head.Next;
                Count--;
                if(Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        public bool Remove(T data)
        {
            Node<T> node = Find(data);
            if (node == null)
                return false;

            Node<T> next = node.Next;
            Node<T> previous = node.Previous;
            if(previous == null)
            {
                Head = next;
                if(Head != null)
                {
                    Head.Previous = null;
                }
            }
            else
            {
                previous.Next = next;
            }

            if(next == null)
            {
                Tail = previous;
                if(Tail != null)
                {
                    Tail.Next = null;
                }
            }
            else
            {
                next.Previous = previous; 
            }
            Count--;
            return true;
        }

        public int Index(T data)
        {
            int index = -1;

            Node<T> current = Head;
            while (current != null)
            {
                index += 1;
                if (current.Data.Equals(data))
                    return index;
                current = current.Next;
            }
            return -1;
        }

    }
}
