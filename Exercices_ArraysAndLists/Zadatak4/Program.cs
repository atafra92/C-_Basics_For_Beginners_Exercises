using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();

            while (true)
            {
                Console.Write("Please enter a name or Quit to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbersList.Add(int.Parse(input));
            }

            foreach (var number in numbersList.Distinct())
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

        }
    }
}
