using System;
using System.Collections.Generic;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.Write("Please enter a series of numbers separated by comma: ");
            string input = Console.ReadLine();

            var nums = input.Split(",");

            for (int i = 0; i < nums.Length; i++)
            {
                var num = int.Parse(nums[i]);
                numbers.Add(num);
                numbers.Sort();            
            }

            if (numbers.Count >= 5)
            {
                var smallestNumbers = numbers.GetRange(0, 3);

                    Console.WriteLine($"The 3 smallest numbers are: { smallestNumbers[0] }, { smallestNumbers[1] }, { smallestNumbers[2]}");               
            }
            else
            {
                Console.WriteLine("Invalid List");
            }
            
            Console.ReadLine();

        }
    }
}
