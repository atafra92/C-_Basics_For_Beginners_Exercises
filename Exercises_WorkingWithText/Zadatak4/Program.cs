using System;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write a few words separated by a space: ");
            string input = Console.ReadLine();

            var words = input.Split(" ");

            string pascalCase = "";
        
            foreach (var word in words)
            {
                int length = word.Length - 1;
                pascalCase += word.Substring(0, 1).ToUpper() + word.Substring(1, length).ToLower();
            }

            Console.WriteLine($" PascalCase representation of a input word: { pascalCase }");
            Console.ReadLine();
        }
    }
}
