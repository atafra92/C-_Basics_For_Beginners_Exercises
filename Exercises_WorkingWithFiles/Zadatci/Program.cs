using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Zadatci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadatak 1
            string path = @"C:\Users\DELL\Desktop\Udemy_CSharp_Basics_for_Beginners\Exercices\CSharp_Basics_For_Beginners_Exercises\Exercises_WorkingWithFiles\Zadatak1.txt";
            string textFile = File.ReadAllText(path);

            var words = textFile.Split(" ");

            Regex regex = new Regex("[^A-Za-z0-9]");
           
            int counter = 0;

            foreach (var word in words)
            {
                string cleanedWord = regex.Replace(word, "");

                if (!string.IsNullOrWhiteSpace(cleanedWord))
                {
                    counter++;
                }  
            }

            Console.WriteLine($"Number of words in text: { counter }");

            //Zadatak 2

            var longestWord = regex.Replace(words[0], "");

            for (int i = 0; i < words.Length; i++)
            {
                string cleanedWord = regex.Replace(words[i], "");

                if (!string.IsNullOrWhiteSpace(cleanedWord))
                {
                    if (cleanedWord.Length > longestWord.Length)
                    {
                        longestWord = cleanedWord;
                    }
                }
            }

            Console.WriteLine($"Longest word is: { longestWord }");
        }
    }
}
