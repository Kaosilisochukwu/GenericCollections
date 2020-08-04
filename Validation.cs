using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection
{
    public class Validation
    {
        public int IntIsValid(string userInput)
        {
            int value;
            while (!int.TryParse(userInput, out value)) 
            {
                Console.WriteLine("Please Enter a valid integer");
                userInput = Console.ReadLine();
            }
            return value;
        }
        public double DoubleIsValid(string userInput)
        {
            double value;
            while (!double.TryParse(userInput, out value))
            {
                Console.WriteLine("Please Enter a valid integer");
                userInput = Console.ReadLine();
            }
            return value;
        }
        public decimal DecimalIsValid(string userInput)
        {
            decimal value;
            while (!decimal.TryParse(userInput, out value))
            {
                Console.WriteLine("Please Enter a valid integer");
                userInput = Console.ReadLine();
            }
            return value;
        }
    }
}
