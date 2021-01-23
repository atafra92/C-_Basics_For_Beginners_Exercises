using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();

            Console.Write("Enter a few numbers separated by '-' or pres 'Enter' to exit: ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input) == false)
            {
                var strNumbers = input.Split("-");

                foreach (var number in strNumbers)
                {
                    numbers.Add(int.Parse(number));
                }

                if(numbers.Count != numbers.Distinct().Count())
                {
                    Console.WriteLine("List contains duplicate numbers");
                }
                else
                {
                    Console.WriteLine("Regular list");
                }
            }
            else
            {
                return;
            }

            Console.ReadLine();
        }
    }
}
