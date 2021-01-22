using System;
using System.Collections.Generic;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Please enter { i }. number: ");
                int number = int.Parse(Console.ReadLine());

                if (numbers.Contains(number) == false)
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("You already entered that number. Try again!");
                    i--;
                }
            }

            numbers.Sort();
            foreach (var num in numbers)
            {
                Console.Write($"{ num } ");

            }

            Console.ReadLine();

        }
    }
}
