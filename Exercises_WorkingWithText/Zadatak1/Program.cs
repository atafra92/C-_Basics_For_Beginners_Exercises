using System;
using System.Collections.Generic;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a few numbers separated by '-' : ");
            string input = Console.ReadLine();

            var strNumbers = input.Split("-");
            List<int> numbers = new List<int>();

            bool isConsecutive = true;

            foreach (var number in strNumbers)
            {              
                numbers.Add(int.Parse(number));
            }

            for (int i = 1; i < numbers.Count; i++)
            {
                if ((numbers[i] != numbers[i - 1] + 1) && (numbers[i] != numbers[i - 1] - 1))
                {
                    isConsecutive = false;
                    break;
                }
            }
            
            var result = (isConsecutive) ? "Consecutive" : "Not consecutive";

            Console.WriteLine($"The numbers are { result }");

            Console.ReadLine();

        }
    }
}
