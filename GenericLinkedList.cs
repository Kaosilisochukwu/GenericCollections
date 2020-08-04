using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    class GenericLinkedList<T>
    {

        //DEFINES THE PROPERTIES OF THE GENERIC-LINKEDLIST CLASS
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }


        //AN OVERLOADED METHOD TO ADD A NODE AT THE BEGINNING OF THE LIST
        public void AddHead(T data)
        {
            AddHead(new Node<T>(data));
        }
        
        //A METHOD TO ADD A NODE TO THE BEGINNING OF THE LIST
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

        //AN OVERLOADED METHOD TO ADD A NODE TO THE LIST
        public void AddTail(T data)
        {
            AddTail(new Node<T>(data));
        }


        //METHOD TO ADD A NODE TO THE END OF THE LIST
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
    
        // METHOD TO RETURN THE NODE THAT CONTAINS A DATA IN THE LIST
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

        //MOTHOD TO CHECK IF THE LIST IS EMPTY
        public bool isEmpty() => Count == 0;
        
        //MOTHOD TO RETURN THE VALUE IN NODE
        public T Search(T data)
        {
            return Find(data).Data;
        }

        //METHOD TO ADD A NODE TO THE BEGINNING OF A LIST
        public int Add(T data)
        {
            AddHead(data);
            return Count;
        }

        //METHOD TO CHECK IF A NODE EXISTS IN A LIST
        public bool Contains(T data) => Find(data) != null;

        //METHOD TO RETURN THE NUMBER OF ITEMS IN A LIST
        public int Size() => Count;



        //METHOD TO INSERT A NODE AT A PARTICULAR INDEX IN THE LIST
        public void Insert(T data, int index)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = Head;
            //CHECKS IF THE INDEX EXCEEDS THE LAST INDEX OF THE LIST
            if (index >= Count)
                throw new ArgumentException($"index is out of range.");
            //KEEPS TRACK OF THE POSITION OF THE CURRENT NODE
            int currentIndex = 0;
            //LOOPS THROUGH TO GET THE NODE AT THE REQUIRED INDEX
            while (tempNode != null)
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
            //CONDITON TO INSERT A NODE AT THE END OF THE LIST
            if (previous == null)
            {
                Head = node;
                Head.Next = tempNode;
                previous = Head;
            }
            else
            {
                previous.Next = node;
                node.Next = tempNode;
                tempNode.Previous = node;
                node.Previous = previous;
            }
            Count++;
        }

        //METHOD TO REMOVE THE LAST ITEM IN THE LIST
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

        //REMOVES THE FIRST NODE IN THE LIST
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

        //LINKED-LIST REMOVE METHOD THAT REMOVES THE FIRST OCCURANCE OF A NODE IN THE LIST
        public bool Remove(T data)
        {
            //FINDS THE FIRST NODE THAT HAS THE VALUE TO BE REMOVED
            Node<T> node = Find(data);

            //CHECKS IF THE NODE EXITS AND RETURNS FALSE IF IT DOES NOT
            if (node == null)
                return false;

            //REMOVES AN ITEM ACCORDING TO ITS POSITION IN THE LIST AND RETURNS TRUE
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

        //LINKED-LIST INDEX METHOD THAT RETURNS THE INDEX OF A VALUE IN THE LIST
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

        //LIST METHOD THAT PRINTS ALL THE CONTENT OF THE LIST TO THE CONSOLE
        public void Print()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

    }
}
