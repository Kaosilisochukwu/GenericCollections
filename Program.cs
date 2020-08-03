using System;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ints = new LinkedList<int>();
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
            Console.WriteLine(ints.Index(7));
            Console.WriteLine(ints.Index(10));
            Console.WriteLine(ints.Index(40));
            Console.WriteLine(ints.Count);
            ints.RemoveTail();
            Console.WriteLine(ints.Count);
        }
    }
}
