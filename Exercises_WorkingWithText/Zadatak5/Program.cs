using System;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write an English word: ");
            string input = Console.ReadLine();

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] strArray = input.ToLower().ToCharArray();

            int vowelsCount = 0;

            foreach (var letter in strArray)
            {
                foreach (var vowel in vowels)
                {
                    if(letter == vowel)
                    {
                        vowelsCount++;
                    }
                }
            }
            Console.WriteLine($"Number of vowels in a word input: { vowelsCount }");

            Console.ReadLine();

        }
    }
}
