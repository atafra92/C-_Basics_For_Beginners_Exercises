using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Please enter a name or press Enter to quit: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                names.Add(name);
            }

            if (names.Count == 0)
            {
                Console.WriteLine();
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{ names[0] } and { names[1] } like your post");
            }
            else if (names.Count > 2)
            {
                Console.WriteLine($"{ names[0] }, { names[1] } and { names.Count - 2 } others like your post");
            }

            Console.ReadLine();
        }
    }
}
