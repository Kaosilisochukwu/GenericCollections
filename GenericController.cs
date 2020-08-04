using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    public static class GenericController
    {
        public static void Run()
        {
            DataChoice:
            Console.WriteLine(@"Please choose the type of value you want to work with

                                                     For string type 'S'
                                                     For int   type 'I'
                                                     For double type 'D'
                                                     For decimal type 'F'
                                                      To exit type 'E'");
            string userInput = Console.ReadLine().ToLower();
            if (userInput != "e" && userInput != "i" && userInput != "s" && userInput != "d" && userInput != "f")
            {
                Console.WriteLine("Please type in a valid option");
                goto DataChoice;
            }
            if (userInput == "e")
                goto End;
            else if(userInput == "s")
            {
                Collectiontype:
                Console.WriteLine(@"What data structure  would you like to work with?

                                                          For Stack type 'S'
                                                          For Linked List   type 'L'
                                                          For Queue type 'Q'
                                                          To exit type 'E'");
                string operationInput = Console.ReadLine().ToLower();
                if(operationInput != "e" && operationInput != "l" && operationInput != "s" && operationInput != "q")
                {
                    Console.WriteLine("Please type in a valid option");
                    goto Collectiontype;
                }
                if(operationInput == "e")
                {
                    goto DataChoice;
                }
                else if (operationInput == "s")
                {
                    GenericStack<string> genericStack = new GenericStack<string>();
                }
                else if (operationInput == "q")
                {
                    GenericQueue<string> genericQueue = new GenericQueue<string>();
                }
                else if (operationInput == "l")
                {
                    LinkedList<string> linkedList = new LinkedList<string>();
                }

            }
            else if (userInput == "i")
            {

            }
            else if (userInput == "d")
            {

            }
            else if (userInput == "f")
            {

            }
            End:
            Console.WriteLine("Goodbye");
        }
    }
}
