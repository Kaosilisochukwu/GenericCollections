using System;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericLinkedList<int> ints = new GenericLinkedList<int>();
            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.isEmpty());
            ints.isEmpty();
            ints.Add(5);
            ints.Add(3);
            ints.Add(6);
            ints.Add(9);
            Console.WriteLine(ints.isEmpty());
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
            ints.Print();
            Console.WriteLine(ints.Count);
            GenericStack<string> strings = new GenericStack<string>();
            strings.Push("corn");
            strings.Push("Yam");
            strings.Pop();
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine(strings.Peek());
            Console.WriteLine(strings.isEmpty());
            strings.Print();
            Console.WriteLine("---------------------------------------------");
            GenericQueue<string> stringer = new GenericQueue<string>();
            Console.WriteLine(stringer.IsEmpty());
            stringer.Enqueue("Deola");
            stringer.Enqueue("Precious");
            Console.WriteLine(strings.Peek());
            Console.WriteLine(stringer.IsEmpty());
            stringer.Print();
        }
    }
}
