using System;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericLinkedList<int> ints = new GenericLinkedList<int>();
            Console.WriteLine(ints.Count);
            ints.AddHead(5);
            ints.AddHead(3);
            ints.AddHead(6);
            ints.AddHead(9);
            ints.Remove(3);
            ints.Insert(7, 0);
            ints.Insert(10, 3);
            Console.WriteLine(ints.Index(10));
            Console.WriteLine("------------------------------------------");
            ints.Insert(40, 3);
            Console.WriteLine(ints.Index(5));
            Console.WriteLine(ints.Index(3));
            Console.WriteLine(ints.Index(7));
            Console.WriteLine(ints.Index(10));
            Console.WriteLine(ints.Index(40));
            Console.WriteLine(ints.Add(5));
            Console.WriteLine(ints.Count);
            ints.RemoveTail();
            Console.WriteLine(ints.Count);
            GenericStack<string> strings = new GenericStack<string>();
            strings.Push("corn");
            Console.WriteLine(strings.isEmpty());
        }
    }
}
